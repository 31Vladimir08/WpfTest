using System;

namespace WpfApp.Models
{
    public class СontractUi : EntityBase
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastDate { get; set; }
        public bool IsActual 
        {
            get
            {
                return LastDate == DateTime.Today.AddDays(-60);
            }
        }
    }
}
