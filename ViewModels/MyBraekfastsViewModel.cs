using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBuberBreakfast.Models;

namespace MauiBuberBreakfast.ViewModels
{
    public partial class MyBraekfastsViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Breakfast> breakfasts;
        
        [ObservableProperty]
        bool isRefreshing;


        public MyBraekfastsViewModel()
        {
            LoadBreakfastsAsync();
        }

        [RelayCommand]
        public async Task LoadBreakfastsAsync()
        {
            try
            {
                await Task.Delay(2000);
                Breakfasts = new()
                {
                    new Breakfast(
                        Name: "Vegan Sunshine",
                        Description: "Vegan everything!",
                        StartDateTime: DateTime.UtcNow.AddDays(1),
                        EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                        Image: new Uri("https://images.unsplash.com/photo-1604242684508-c309e173a3e7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"),
                        Savory: new List<string> { "Oatmeal", "Avocado Toast", "Omelet"},
                        Sweet: new List<string> { "Cokkie" }),
                    new Breakfast(
                        Name: "Big Breakfast",
                        Description: "I am a famous breakfast in the world!",
                        StartDateTime: DateTime.UtcNow,
                        EndDateTime: DateTime.UtcNow.AddHours(2),
                        Image: new Uri("https://images.unsplash.com/photo-1524182732116-a3ad2034503c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"),
                        Savory: new List<string> { "Salad", "Sausage", "Egg"},
                        Sweet: new List<string> { "Waffle", "Pancake" }),
                };
            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}
