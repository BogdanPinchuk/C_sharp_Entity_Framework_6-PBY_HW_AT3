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

            //AppDomain.CurrentDomain.SetData("DataDirectory",
            //    Path.GetDirectoryName(Application.ExecutablePath));
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

            }
        }

        /// <summary>
        /// Закрити форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeMenu_Click(object sender, EventArgs e)
        {
            //db?.Dispose();
            this.Close();
        }

        /// <summary>
        /// Створення ДБ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createMenu_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LesApp0Context>());

            // choose directory for save database
            statusLabel.Text = "Start creating";
            Cursor = Cursors.AppStarting;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.path = folderBrowser.SelectedPath;

                // choose directory and save data there
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                using (db = new LesApp0Context())
                {
                    db.Audiences.Load();
                    db.SaveChanges();

                    // load data
                    LoadDBOnForm(db);
                }

            }

            // finish
            statusLabel.Text = "Finish creating";
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Завантаження БД на форму
        /// </summary>
        private void LoadDBOnForm(LesApp0Context db)
        {
            dataGrid.DataSource = db.Audiences.Local;
        }


    }
}
