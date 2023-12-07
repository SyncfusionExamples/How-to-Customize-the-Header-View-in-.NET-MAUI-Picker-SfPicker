using Syncfusion.Maui.Picker;
using System.Collections.ObjectModel;

namespace CustomHeader;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ObservableCollection<object> cityName = new ObservableCollection<object>();
        cityName.Add("UnitedStates");
        cityName.Add("Qatar");
        cityName.Add("India");
        cityName.Add("Germany");
        cityName.Add("Spain");
        cityName.Add("Malaysia");
        cityName.Add("Netherlands");
        cityName.Add("Mexico");
        cityName.Add("Brazil");
        PickerColumn pickerColumn = new PickerColumn()
        {
            ItemsSource = cityName,
            SelectedIndex = 4,
        };
        picker.Columns.Add(pickerColumn);
    }
}