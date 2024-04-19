using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp 
{
    /// <summary>
    /// Класс, представляющий проект.
    /// </summary>
    public class Project
    {
        private List<Note> notes;

        /// <summary>
        /// Список заметок в проекте.
        /// </summary>
        public List<Note> Notes
        {
            get { return notes; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Project.
        /// </summary>
        public Project()
        {
            notes = new List<Note>();
        }

        /// <summary>
        /// Добавляет заметку в проект.
        /// </summary>
        /// <param name="note">Заметка для добавления.</param>
        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        /// <summary>
        /// Удаляет заметку из проекта.
        /// </summary>
        /// <param name="note">Заметка для удаления.</param>
        public void RemoveNote(Note note)
        {
            notes.Remove(note);
        }

    }
}
