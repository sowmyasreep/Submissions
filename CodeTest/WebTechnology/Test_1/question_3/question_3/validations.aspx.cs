using System;
using System.Web.UI;
 


    public partial class Validator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
 
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Retrieve the input values
            string name = txtName.Text;
            string familyName = txtFamilyName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
 
            // Perform the validation actions
            bool isValid = true;
 
            if (name == familyName)
            {
                // Name should be different from family name
                isValid = false;
            }
 
            if (address.Length < 2 || city.Length < 2)
            {
                // Address and city should be at least 2 letters
                isValid = false;
            }
 
            if (!System.Text.RegularExpressions.Regex.IsMatch(zipCode, @"^\d{5}$"))
            {
                // Zip code should have 5 digits
                isValid = false;
            }
 
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{2}-\d{7}$") && !System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{3}-\d{7}$"))
            {
                // Phone should follow the format XX-XXXXXXX or XXX-XXXXXXX
                isValid = false;
            }
 
            if (!System.Net.Mail.SmtpClient.VerifiziereMailadresse(email))
            {
                // Validate the email address (You can use your email validation logic)
                isValid = false;
            }
 
            // Display the result on a new page or as per your requirements
            if (isValid)
            {
                // Redirect to a success page or display a success message
                Response.Redirect("Success.aspx");
            }
            else
            {
                // Redirect to an error page or display an error message
                Response.Redirect("Error.aspx");
            }
        }
    }
