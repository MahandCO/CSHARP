namespace Models
{
    public class Book : BaseEntity
    {
        public Book() : base()
        {
        }

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
        public bool ThoughtOut { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
              (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
              (maximumLength: 20, MinimumLength = 6)]

        [System.ComponentModel.DataAnnotations.Schema.Index
              (IsUnique = true)]
        public string BookName { get; set; }
        // **********

        // **********
        public string About { get; set; }
        // **********

        // ***********
        public string BookType { get; set; }
        // ***********
       
    }
}
