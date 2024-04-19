using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, представляющий заметку.
    /// </summary>
    public class Note : ICloneable
    {
        private string title;
        private string category;
        private string text;
        private readonly DateTime creationTime;
        private DateTime lastModifiedTime;

        /// <summary>
        /// Название заметки.
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Title cannot exceed 50 characters.");
                }
                title = value;
                lastModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Категория заметки.
        /// </summary>
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                lastModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Текст заметки.
        /// </summary>
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                lastModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        public DateTime CreationTime => creationTime;

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        public DateTime LastModifiedTime => lastModifiedTime;

        /// <summary>
        /// Инициализирует новый экземпляр класса Note.
        /// </summary>
        public Note()
        {
            creationTime = DateTime.Now;
            lastModifiedTime = creationTime;
            title = "Без названия";
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Note с указанным названием, категорией и текстом.
        /// </summary>
        /// <param name="title">Название заметки.</param>
        /// <param name="category">Категория заметки.</param>
        /// <param name="text">Текст заметки.</param>
        public Note(string title, string category, string text)
        {
            if (title.Length > 50)
            {
                throw new ArgumentException("Title cannot exceed 50 characters.");
            }
            this.title = title;
            this.category = category;
            this.text = text;
            creationTime = DateTime.Now;
            lastModifiedTime = creationTime;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

