using CommunityToolkit.Maui.Views;

namespace LabelTextWrapTest;

public partial class ClonePopup : Popup
{
    
    public ClonePopup() =>
        InitializeComponent();
    
    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }


}