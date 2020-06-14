using System;
using System.Collections.Generic;

namespace RGR.models {
    public class Event {
        public Event() { }

        public Event(int id, string name, string description, DateTime date, Place place, Company organizer,
            EventType eventType, List<User> participants, List<User> guests) {
            this.id = id;
            this.name = name;
            description = description;
            this.date = date;
            this.place = place;
            this.organizer = organizer;
            this.eventType = eventType;
            this.participants = participants;
            this.guests = guests;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public Place place { get; set; }
        public Company organizer { get; set; }
        public EventType eventType { get; set; }
        public List<User> participants { get; set; }
        public List<User> guests { get; set; }
    }
}