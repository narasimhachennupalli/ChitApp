# ChitFundManager

A WPF desktop application built with .NET 8 following the MVVM (Model-View-ViewModel) architecture pattern.

## Architecture

This application follows the MVVM design pattern, which provides a clean separation of concerns:

### Project Structure

```
ChitFundManager/
├── Models/               # Data models and business entities
│   ├── ChitFund.cs      # Chit fund group model
│   └── Member.cs        # Member model
├── Views/               # XAML views (UI)
│   └── MainWindow.xaml  # Main application window
├── ViewModels/          # ViewModels (presentation logic)
│   ├── ViewModelBase.cs # Base class for all ViewModels
│   └── MainViewModel.cs # ViewModel for MainWindow
├── Helpers/             # Helper classes
│   └── RelayCommand.cs  # ICommand implementation
├── App.xaml             # Application entry point
└── ChitFundManager.csproj
```

### MVVM Components

- **Models**: Plain C# classes representing business entities (ChitFund, Member)
- **Views**: XAML files defining the user interface
- **ViewModels**: Classes that mediate between Views and Models, implementing INotifyPropertyChanged
- **Helpers**: Utility classes like RelayCommand for command binding

## Building the Application

### Prerequisites
- .NET 8 SDK or later
- Visual Studio 2022 or JetBrains Rider (optional)

### Build Instructions

```bash
dotnet restore
dotnet build
```

### Run the Application

```bash
dotnet run
```

## Features

- Clean MVVM architecture
- Data binding between Views and ViewModels
- Command pattern implementation with RelayCommand
- Property change notification via ViewModelBase
- Modern WPF UI design

## Technology Stack

- .NET 8
- WPF (Windows Presentation Foundation)
- C# 12
- XAML

## Development Notes

- The project uses implicit usings and nullable reference types
- All ViewModels inherit from `ViewModelBase` which implements `INotifyPropertyChanged`
- Commands are implemented using the `RelayCommand` helper class
- Views are bound to ViewModels through the `DataContext` property
