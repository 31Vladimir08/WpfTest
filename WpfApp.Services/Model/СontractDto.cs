using System;

namespace WpfApp.Services.Model
{
    public class СontractDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastDate { get; set; }
        public bool IsActual { get; set; }
    }
}
