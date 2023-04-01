/*
 * Author: Yaju Shrestha
 * Assignment: Car Wash 
 * Description: This program is simulating an app that calculates the total amount a customer has to pay when selecting a program and add ons at LENNYS CAR WASH.
 * 
 * 

 
 */
namespace Program_3_Carwash;

public partial class Receipt : ContentPage
{
	public Receipt(int total, string wash, List<string> addOns)
	{
		InitializeComponent();

        code1.Text = $"Wash Selected: {wash}\r\n\n Add Ons Purchesd: {print(addOns)}\n";
        totalAmount.Text= "Total Cost: $"+total.ToString()+".00";
	}

	public string print(List<string> addOns)
	{
        string temp = "";

        foreach (string o in addOns)
		{
			
			temp = temp + "\n\t" + o  ;
		}
		return temp;
	}

    public void onClick2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}