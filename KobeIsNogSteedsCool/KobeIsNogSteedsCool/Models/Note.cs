using System;
using System.Collections.Generic;
using System.Text;

namespace KobeIsNogSteedsCool.Models
{
    internal class Note
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}