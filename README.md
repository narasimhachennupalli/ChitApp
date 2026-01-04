# ChitApp

A WPF desktop application for managing chit funds, built with .NET 8 and following the MVVM architecture pattern.

## Project: ChitFundManager

ChitFundManager is a Windows Presentation Foundation (WPF) application that demonstrates clean MVVM architecture implementation.

### Features
- Built with .NET 8
- MVVM architecture pattern
- Clean separation of concerns
- Data binding and command pattern
- Modern WPF UI design

### Getting Started

#### Prerequisites
- .NET 8 SDK or later
- Visual Studio 2022 or JetBrains Rider (recommended for Windows)

#### Building the Application
```bash
dotnet build ChitFundManager.sln
```

#### Running the Application
```bash
cd ChitFundManager
dotnet run
```

### Project Structure
See [ChitFundManager/README.md](ChitFundManager/README.md) for detailed documentation.

### Architecture
The application follows the MVVM pattern with:
- **Models**: Business entities (ChitFund, Member)
- **Views**: XAML UI definitions
- **ViewModels**: Presentation logic with data binding
- **Helpers**: Utility classes for MVVM support
