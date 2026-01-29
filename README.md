# EventEase - Blazor Web Application

**EventEase** is a modern Blazor Web Application for corporate and social event management, built with Microsoft's latest web technologies and best practices.

![EventEase Banner](https://via.placeholder.com/800x200?text=EventEase+Event+Management)

## 📋 Project Overview

EventEase enables users to:

- **Browse Events**: Discover corporate and social events with comprehensive details
- **View Details**: Access full event information including date, time, location, and description
- **Register**: Complete a streamlined registration process for events
- **Navigate Seamlessly**: Move between pages with intuitive breadcrumb navigation

This project was built as part of a GitHub Copilot-assisted development exercise, demonstrating modern Blazor component architecture, routing patterns, and best practices.

## 🚀 Quick Start

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio Code, Visual Studio 2022, or compatible IDE
- Browser (Chrome, Firefox, Safari, or Edge)

### Installation & Running

```bash
# Navigate to project directory
cd EventAppDemo/EventEaseApp

# Restore dependencies
dotnet restore

# Run the application
dotnet run

# Open browser to displayed URL (typically https://localhost:5001)
```

## 📁 Project Structure

```
EventEaseApp/
├── Components/
│   ├── Pages/
│   │   ├── Home.razor                 # Landing page
│   │   ├── Home.razor.css
│   │   ├── Events.razor               # Event list
│   │   ├── Events.razor.css
│   │   ├── EventDetails.razor         # Event details
│   │   ├── EventDetails.razor.css
│   │   ├── Register.razor             # Registration form
│   │   ├── Register.razor.css
│   │   └── [Other pages...]
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor              # Navigation
│   │   └── MainLayout.razor.css
│   ├── EventCard.razor                # Reusable component
│   ├── EventCard.razor.css
│   ├── Routes.razor
│   └── App.razor
├── Models/
│   └── Event.cs                       # Data model
├── Services/
│   └── EventService.cs                # Business logic
├── Program.cs
├── EventEaseApp.csproj
└── [Configuration files...]
```

## 🎯 Key Features Implemented

### ✅ Event Card Component

- Reusable component for displaying event summaries
- Fields: Name, Date, Location, Capacity indicator
- Data binding for dynamic content
- Event callbacks for user interactions
- Scoped CSS styling

### ✅ Routing System

- Clean, semantic URL structure
- Type-safe route parameters
- Automatic file-based routing
- Breadcrumb navigation support

**Routes**:
| URL | Component | Purpose |
|-----|-----------|---------|
| `/` | Home | Landing page with features |
| `/events` | Events | Browse all events |
| `/event-details/{id}` | EventDetails | View event details |
| `/register/{id}` | Register | Event registration form |

### ✅ Pages

- **Home**: Landing page with feature highlights
- **Events List**: Grid of event cards with navigation
- **Event Details**: Full event information and registration button
- **Registration**: Form for user registration with validation

### ✅ Data Binding

- Two-way binding (`@bind`) for form inputs
- Safe navigation operators (`?.`)
- Component parameters for data flow
- Event callbacks for parent notification

### ✅ Styling

- Scoped CSS per component (CSS isolation)
- Responsive design (mobile-first)
- Gradient headers and smooth transitions
- Consistent color scheme (purple/gray/green)
- Flexbox and CSS Grid layouts

## 📊 Data Model

### Event Class

```csharp
public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int RegisteredCount { get; set; }
}
```

### Mock Data

The application includes 5 sample events:

1. **Annual Tech Summit 2026** - March 15, San Francisco (312/500)
2. **Web Development Workshop** - February 20, Austin (48/50)
3. **Corporate Leadership Gala** - March 25, Manhattan (156/200)
4. **Startup Pitch Competition** - April 10, Boston (195/300)
5. **Cloud Security Conference** - May 5, Seattle (285/400)

## 🔗 Navigation Flow

```
Home Page (/)
    ↓
    ├─ Browse Events Link
    │   ↓
    │   Events List (/events)
    │   │
    │   └─ EventCard → View Details
    │       ↓
    │       Event Details (/event-details/{id})
    │       │
    │       ├─ Register Button
    │       │   ↓
    │       │   Registration (/register/{id})
    │       │   │
    │       │   └─ Submit
    │       │       ↓
    │       │       Back to Events
    │       │
    │       └─ Breadcrumb ← Back to Events
    │
    └─ Navigation Menu ← Always Visible
```

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core + Blazor Web App
- **Runtime**: .NET 8.0
- **Styling**: CSS3 with scoped styling
- **Architecture**: Component-based with services
- **Routing**: File-based automatic routing
- **Data**: Mock service (easily replaceable with database)

## 📚 Documentation

- **[ARCHITECTURE.md](ARCHITECTURE.md)** - Detailed component architecture and routing
- **[QUICKSTART.md](QUICKSTART.md)** - Step-by-step usage guide
- **[BESTPRACTICES.md](BESTPRACTICES.md)** - Best practices applied and Copilot suggestions

## ✨ Best Practices Applied

### Component Design

- ✅ Single Responsibility Principle
- ✅ Reusable, composable components
- ✅ CSS isolation per component
- ✅ Type-safe parameters

### Data Binding

- ✅ Two-way binding for forms
- ✅ Safe navigation operators
- ✅ Proper null handling
- ✅ Event-based communication

### Routing

- ✅ Type-safe route parameters
- ✅ Meaningful URL structure
- ✅ Programmatic navigation
- ✅ Breadcrumb support

### Services

- ✅ Dependency injection
- ✅ Single responsibility
- ✅ Mockable for testing
- ✅ Async-ready

### Styling

- ✅ Mobile-responsive
- ✅ CSS Grid and Flexbox
- ✅ Consistent color scheme
- ✅ Smooth transitions

## 🎓 Learning Resources

This project demonstrates:

- Blazor component architecture
- Razor syntax and data binding
- Service-oriented design
- Responsive CSS design
- Routing in Blazor applications
- Form handling and validation
- Component communication patterns

Perfect for learning Blazor development with modern best practices!

## 🔄 Using EventService

```csharp
// Inject the service
@inject EventService EventService

// Get all events
var events = EventService.GetMockEvents();

// Get specific event
var eventItem = EventService.GetEventById(1);

// Filter by location
var localEvents = EventService.GetEventsByLocation("Austin");

// Get upcoming events
var upcoming = EventService.GetUpcomingEvents();

// Register for event
var success = EventService.RegisterForEvent(1);
```

## 🎨 Customization

### Colors

Edit component CSS files to change the color scheme:

- Primary: `#667eea` (purple)
- Secondary: `#764ba2` (dark purple)
- Success: `#48bb78` (green)
- Text: `#333` (dark gray)

### Mock Data

Edit `EventService.cs` to add/modify events in the `InitializeMockData()` method.

### Styling

Each component has a corresponding `.razor.css` file for style customization.

## 🚀 Future Enhancements

Ready for:

1. Database integration (replace EventService mock data)
2. User authentication and profiles
3. Payment processing for paid events
4. Email notifications
5. Advanced search and filtering
6. User reviews and ratings
7. Event analytics and reporting
8. Admin dashboard

## 🤝 Built With GitHub Copilot

This application was developed with the assistance of GitHub Copilot, demonstrating:

- Copilot-assisted component scaffolding
- Best practice recommendations
- Code pattern suggestions
- Documentation generation

## 📝 License

This project is provided as-is for educational purposes.

## 📞 Support

For questions or issues:

1. Check [QUICKSTART.md](QUICKSTART.md) for usage help
2. Review [ARCHITECTURE.md](ARCHITECTURE.md) for technical details
3. See [BESTPRACTICES.md](BESTPRACTICES.md) for implementation patterns

---

**Built with ❤️ using Blazor and GitHub Copilot**

**Status**: ✅ Complete - Ready to run and customize
