using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    /// <summary>
    /// Service for managing events and event-related operations
    /// </summary>
    public class EventService
    {
        private static List<Event> mockEvents = new();

        public EventService()
        {
            InitializeMockData();
        }

        /// <summary>
        /// Initialize mock events data
        /// </summary>
        private void InitializeMockData()
        {
            if (mockEvents.Count == 0)
            {
                mockEvents = new List<Event>
                {
                    new Event
                    {
                        Id = 1,
                        Name = "Annual Tech Summit 2026",
                        Date = new DateTime(2026, 3, 15, 9, 0, 0),
                        Location = "San Francisco Convention Center",
                        Description = "Join industry leaders and innovators for a full day of presentations, workshops, and networking. Explore the latest trends in cloud computing, AI, and digital transformation.",
                        Capacity = 500,
                        RegisteredCount = 312
                    },
                    new Event
                    {
                        Id = 2,
                        Name = "Web Development Workshop",
                        Date = new DateTime(2026, 2, 20, 14, 0, 0),
                        Location = "Austin Tech Hub",
                        Description = "Learn modern web development practices with hands-on coding sessions. Topics include Blazor, ASP.NET Core, and responsive design.",
                        Capacity = 50,
                        RegisteredCount = 48
                    },
                    new Event
                    {
                        Id = 3,
                        Name = "Corporate Leadership Gala",
                        Date = new DateTime(2026, 3, 25, 18, 30, 0),
                        Location = "Grand Ballroom, Manhattan",
                        Description = "An elegant evening celebrating corporate excellence and leadership achievements. Includes networking dinner and awards ceremony.",
                        Capacity = 200,
                        RegisteredCount = 156
                    },
                    new Event
                    {
                        Id = 4,
                        Name = "Startup Pitch Competition",
                        Date = new DateTime(2026, 4, 10, 10, 0, 0),
                        Location = "Innovation Hub, Boston",
                        Description = "Watch promising startups pitch their ideas to venture capitalists and investors. Open to entrepreneurs and investors interested in emerging technologies.",
                        Capacity = 300,
                        RegisteredCount = 195
                    },
                    new Event
                    {
                        Id = 5,
                        Name = "Cloud Security Conference",
                        Date = new DateTime(2026, 5, 5, 9, 0, 0),
                        Location = "Seattle Convention Center",
                        Description = "Expert-led discussions on the latest cloud security threats, best practices, and compliance strategies for enterprises.",
                        Capacity = 400,
                        RegisteredCount = 285
                    }
                };
            }
        }

        /// <summary>
        /// Get all mock events
        /// </summary>
        public static List<Event> GetMockEvents()
        {
            return mockEvents;
        }

        /// <summary>
        /// Get a specific event by ID
        /// </summary>
        public static Event? GetEventById(int eventId)
        {
            return mockEvents.FirstOrDefault(e => e.Id == eventId);
        }

        /// <summary>
        /// Get events by location
        /// </summary>
        public static List<Event> GetEventsByLocation(string location)
        {
            return mockEvents.Where(e => e.Location.Contains(location, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Get upcoming events
        /// </summary>
        public static List<Event> GetUpcomingEvents()
        {
            return mockEvents.Where(e => e.Date > DateTime.Now).OrderBy(e => e.Date).ToList();
        }

        /// <summary>
        /// Register a user for an event
        /// </summary>
        public static bool RegisterForEvent(int eventId)
        {
            var eventItem = GetEventById(eventId);
            if (eventItem != null && eventItem.RegisteredCount < eventItem.Capacity)
            {
                eventItem.RegisteredCount++;
                return true;
            }
            return false;
        }
    }
}
