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
        /// <param name="path">директорія файла</param>
        /// <param name="filename">ім'я файла без розширення</param>
        public LesApp0Context(string path, string filename)
            : base(CreateFullPath(path, filename)) { }

        /// <summary>
        /// Налаштування шляху створення БД
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        private static string CreateFullPath(string path, string filename)
            => new StringBuilder()
            .Append(@"data source = (LocalDb)\MSSQLLocalDB;")
            .Append($@"AttachDbFilename = {path}\{filename}.mdf;")
            .Append($@"Initial Catalog = {filename}; ")
            .Append("Integrated Security=True;")
            .ToString();

        /// <summary>
        /// Аудиторії
        /// </summary>
        public virtual DbSet<Audience> Audiences { get; set; }
    }
}