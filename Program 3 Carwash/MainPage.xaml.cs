/*
 * Author: Yaju Shrestha
 * Assignment: Car Wash 
 * Description: This program is simulating an app that calculates the total amount a customer has to pay when selecting a program and add ons at LENNYS CAR WASH.
 * 
 * 

 
 */
namespace Program_3_Carwash;

public partial class MainPage : ContentPage
{

    List<string> addOns = new List<string>();

	string wash = "";


    public MainPage()
	{
		InitializeComponent();
	}
	public int SelectedOption()
	{
		int total = 0;
		string option;

		if (basicWash.IsChecked)
		{
			option = "Basic Wash ($10.00)";
			total += 10;
		}
		else if (premiumWash.IsChecked)
		{
			option = "Premium Wash ($15.00)";
			total += 15;
		}
		else if (ultraWash.IsChecked) 
		{
			option = "Ultra Wash ($20.00)";
			total += 20;
		}
		else option = string.Empty;
		wash = option;

        return total;
	}

	public int selectedCheck()
	{
		int total = 0;
		if (airFreshener.IsChecked)
		{
			total += 2;
			addOns.Add("• Air Freshener ($2.00)");
		}
		if (waxOnAddOn.IsChecked)
		{
			total += 5;
			addOns.Add("• Wax On Service ($5.00)");
		}
		if (wheelShineAddOn.IsChecked)
		{
			total += 5;
			addOns.Add("• Wheel Shine Service ($5.00)");
		}
		if (vacuumAddOn.IsChecked)
		{
			total += 2;
			addOns.Add("• Vacuum Service ($2.00)");
		}
		if(addOns.Count() == 0)
		{
			addOns.Add("× No Add Ons were Selected");
		}
		
		return total;

        error.Text = total.ToString();

	}

	public void onClick(object sender, EventArgs e)
	{
		int total=0;

		string option = "";

		if(SelectedOption()==0) {
			error.Text = "Error: Please select a wash.";
		}

		else
		{
            total = selectedCheck() + SelectedOption();

            Navigation.PushAsync(new Receipt(total, wash, addOns));
        }
		
    }


}

