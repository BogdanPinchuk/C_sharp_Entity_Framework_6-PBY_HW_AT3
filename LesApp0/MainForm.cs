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
using System.Threading;
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
        private string filename = @"\LesApp0DB.mdf";
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Відкриття БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenMenu_Click(object sender, EventArgs e)
        {
            // choose directory for save database
            Cursor = Cursors.AppStarting;
            statusLabel.Text = "Start loading";

            // запуск відкриття
            OpenFile();
        }

        /// <summary>
        /// Відкриття файлу БД
        /// </summary>
        private void OpenFile()
        {
            // block other menu
            BlockMenu(true);

            if (openFileD.ShowDialog() == DialogResult.OK)
            {
                this.path = Path.GetDirectoryName(openFileD.FileName);
                this.filename = Path.GetFileNameWithoutExtension(openFileD.FileName);

                db?.Dispose();
                //using (db = new LesApp0Context(path, filename))
                //{
                db = new LesApp0Context(path, filename);

                db.Audiences.Load();

                // load data
                LoadDBOnForm(db);
                //}
            }

            // finish
            statusLabel.Text = "Finish loading";
            Cursor = Cursors.Default;

            // unblock
            BlockMenu(false);
        }

        /// <summary>
        /// Блокування меню
        /// </summary>
        /// <param name="value">Результат блокування</param>
        private void BlockMenu(bool value)
        {
            openMenu.Enabled = !value;
            createMenu.Enabled = !value;
            saveMenu.Enabled = !value;
            closeMenu.Enabled = !value;

            groupCRUD.Enabled = !value;
        }

        /// <summary>
        /// Закрити форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMenu_Click(object sender, EventArgs e)
            => this.Close();

        /// <summary>
        /// Створення ДБ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenu_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LesApp0Context>());

            // choose directory for save database
            Cursor = Cursors.AppStarting;
            statusLabel.Text = "Start creating";

            // запуск створення
            CreateFile();
        }

        /// <summary>
        /// Створення файла БД
        /// </summary>
        private void CreateFile()
        {
            // block other menu
            BlockMenu(true);

#if false
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.path = folderBrowser.SelectedPath;

                // choose directory and save data there
                AppDomain.CurrentDomain.SetData("DataDirectory", path);

                db.Dispose();

                db = new LesApp0Context();

                //using (db = new LesApp0Context())
                //{
                db.Audiences.Load();
                db.SaveChanges();

                // load data
                LoadDBOnForm(db);
                //}
            }
#endif
            if (saveFileD.ShowDialog() == DialogResult.OK)
            {
                this.path = Path.GetDirectoryName(saveFileD.FileName);
                this.filename = Path.GetFileNameWithoutExtension(saveFileD.FileName);

                db?.Dispose();

                db = new LesApp0Context(path, filename);
                db.Audiences.Load();
                db.SaveChanges();

                LoadDBOnForm(db);
            }

            // finish
            statusLabel.Text = "Finish creating";
            Cursor = Cursors.Default;

            // unblock
            BlockMenu(false);
        }

        /// <summary>
        /// Завантаження БД на форму
        /// </summary>
        private void LoadDBOnForm(LesApp0Context db)
        {
            dataGrid.DataSource = db.Audiences.Local;
        }

        /// <summary>
        /// При виборі комірки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            statusLabel.Text = dataGrid.CurrentCell?.RowIndex.ToString() +
                $"x" + dataGrid.CurrentCell?.ColumnIndex.ToString();
        }

        /// <summary>
        /// Створення нового рядка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BCreate_Click(object sender, EventArgs e)
        {
            // enabled
            bAdd.Enabled = true;
            bRead.Enabled = false;
            cRead.Enabled = false;
            bUpdate.Enabled = false;
            bRefresh.Enabled = false;
            bDelete.Enabled = true;
            groupRow.Enabled = true;

            // clear
            ClearCell();
        }

        /// <summary>
        /// Видалення рядка або відміна створення нового
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDelete_Click(object sender, EventArgs e)
        {
            // clear
            ClearCell();


            // enabled
            bAdd.Enabled = false;
            bRead.Enabled = true;
            cRead.Enabled = true;
            bUpdate.Enabled = true;
            bRefresh.Enabled = true;
            groupRow.Enabled = false;
        }

        /// <summary>
        /// Очищення комірок
        /// </summary>
        private void ClearCell()
        {
            tbID.Text = string.Empty;
            tbNumber.Text = string.Empty;
            tbCategoty.Text = string.Empty;
            tbCount.Text = string.Empty;
        }

        // TODO: add save to xlsx file of office excel
    }
}
