﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp.Lib.Models
{
    /// <summary>
    /// Аудиторія
    /// </summary>
    public class Audience
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Кількість мість в аудиторії
        /// </summary>
        public int CountOfWorkPlace { get; set; }
        /// <summary>
        /// Номер аудиторії
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Категорія
        /// </summary>
        public string Category { get; set; }

        public override string ToString()
            => $"Audience № {Number}{((Category.Trim() != string.Empty) ? $"-{Category}" : string.Empty)}";
    }
}
