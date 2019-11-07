namespace LesApp.Lib.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Контекст
    /// </summary>
    public class LesApp0Context : DbContext
    {
        public LesApp0Context()
            : base("LesApp0Connection") { }

        /// <summary>
        /// Створення підключення
        /// </summary>
        /// <param name="path">повне ім'я файла</param>
        public LesApp0Context(string path)
            : base(CreateFullPath(path)) { }

        /// <summary>
        /// Створити контекст, так щоб файл знаходився біля exe файла
        /// </summary>
        /// <param name="nearExeFile"></param>
        public LesApp0Context(bool nearExeFile)
            : base((nearExeFile) ? CreateFullPath(Environment.CurrentDirectory) : "LesApp0Connection") { }

        /// <summary>
        /// Установка шляху до БД
        /// </summary>
        /// <param name="path"></param>
        public void SetPath(string path)
            => AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(path));

        /// <summary>
        /// Створення початкових даних
        /// </summary>
        public void CreateData()
            => Database.SetInitializer(new ContextInitializer());

        /// <summary>
        /// Налаштування шляху створення БД
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static string CreateFullPath(string path)
        {
            var s = new StringBuilder()
                .Append(@"data source = (LocalDb)\MSSQLLocalDB;")
                .Append($@"Initial Catalog = |{Path.GetDirectoryName(path) + @"|\" + Path.GetFileNameWithoutExtension(path)}; ")
                .Append("Integrated Security=True; MultipleActiveResultSets=True;App=EntityFramework")
                .ToString();

            return s;
        }

        /// <summary>
        /// Аудиторії
        /// </summary>
        public virtual DbSet<Audience> Audiences { get; set; }
    }
}