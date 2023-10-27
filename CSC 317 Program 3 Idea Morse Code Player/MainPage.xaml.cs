/*

Program Author: Aayush Gautam

Assignment: Morse Code Transmitter

Description:

Controller between the frontend and the backend for the transmitter

*/

using CommunityToolkit.Maui.Views;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Core.Primitives;

namespace CSC_317_Program_3_Idea_Morse_Code_Player;

public partial class MainPage : ContentPage
{
    MorseEncoder morseEncoder;

    public MainPage()
    {
        InitializeComponent();
        morseEncoder = new MorseEncoder();
    }

    private async void SimulateMorse(object sender, EventArgs e)
    {
        btnSimulate.IsEnabled = false;

        string userMessage = entryMessage.Text;
        if (string.IsNullOrEmpty(userMessage))
        {
            await DisplayAlert("Error", "Please enter a message to simulate.", "OK");
            btnSimulate.IsEnabled = true;
            return;
        }

        morseEncoder.Text = userMessage;
        string morseCode = morseEncoder.Morse;

        labelMorseCode.Text = "";
        foreach (char code in morseCode)
        {
            labelMorseCode.Text += code.ToString() + " ";

            if (code == '.')
            {
                // Play Dot sound
                await PlaySound(dot);
            }
            else if (code == '-')
            {
                // Play Dash sound
                await PlaySound(dash);
            }
            else if (code == '/')
            {
                // Wait for 1 second for space
                await Task.Delay(1000);
            }
        }

        labelMorseCode.Text = "";
        btnSimulate.IsEnabled = true;
    }

    private async Task PlaySound(MediaElement sound)
    {
        while (sound.CurrentState == MediaElementState.Playing)
        {
            await Task.Delay(100);
        }

        sound.Play();
        await Task.Delay(sound.Duration + TimeSpan.FromMilliseconds(500));

        sound.Stop();
    }
}
