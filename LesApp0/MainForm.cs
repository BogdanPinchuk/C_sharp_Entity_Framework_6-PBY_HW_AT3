using LesApp.Lib.Context;
using LesApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesApp0
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// DataBase
        /// </summary>
        private LesApp0Context db;
        /// <summary>
        /// Path to file DB
        /// </summary>
        private string path;

        public MainForm()
        {
            InitializeComponent();

            //AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Application.ExecutablePath));
        }

        /// <summary>
        /// Відкриття БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenu_Click(object sender, EventArgs e)
        {
            if (openFileD.ShowDialog() == DialogResult.OK)
            {
                this.db = new LesApp0Context(Path.GetDirectoryName(openFileD.FileName) +
                    @"\" + Path.GetFileNameWithoutExtension(openFileD.FileName));
                LoadDBOnForm();
            }
        }

        /// <summary>
        /// Закрити форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeMenu_Click(object sender, EventArgs e)
        {
            db.Dispose();
            this.Close();
        }

        /// <summary>
        /// Створення ДБ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createMenu_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Application.ExecutablePath));
                //Database.SetInitializer(new DropCreateDatabaseAlways<LesApp0Context>());

                //AppDomain.CurrentDomain.SetData("DataDirectory", Environment.CurrentDirectory);
                //AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(path));
                //this.db = new LesApp0Context(folderBrowser.SelectedPath + @"\LesApp0DB");
                db = new LesApp0Context();
                var b = db.Database.Connection.ConnectionString;
                //db.CreateData();
                //db.Audiences.Load();
                Audience aa = new Audience() { Number = 512, Category = "a", CountOfWorkPlace = 20 };
                this.db.Audiences.Add(aa);
                this.db.SaveChanges();

                LoadDBOnForm();
            }
        }

        /// <summary>
        /// Завантаження БД на форму
        /// </summary>
        private void LoadDBOnForm()
        {
            if (db.Configuration.UseDatabaseNullSemantics)
            {
                dataGrid.DataSource = db.Audiences.Local;
            }
        }


    }
}
