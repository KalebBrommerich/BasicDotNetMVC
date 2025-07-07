namespace BasicDotNetMVC.Models
{
    public class ContactFormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        
        public void SubmitForm()
        {
            //This is a placeholder for form submission stuff
            System.Console.WriteLine("Form submitted successfully!");
        }
    }
}
