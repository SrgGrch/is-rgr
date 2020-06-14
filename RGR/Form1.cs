using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;
using RGR.models;

namespace RGR {
    public partial class Form1 : Form {
        private static string _url = "http://localhost:1984/";
        private static HttpClient HttpClient;
        private List<Event> events;
        private Event currentEvent;
        private int currentIndex;
        private int newPlaceId;

        public Form1() {
            HttpClient = new HttpClient();
            InitializeComponent();
            loadEvents();
            button_savePlace.Enabled = false;
        }

        private async void loadEvents() {
            var response = await HttpClient.GetAsync(_url + "Events/GetAll");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var events = JsonSerializer.Deserialize<List<Event>>(responseBody);
            this.events = events;
            currentEvent = events[currentIndex];
            drawEvent();
        }

        private void drawEvent() {
            textBox_eventName.Text = currentEvent.name;
            textBox_eventDescription.Text = currentEvent.description;
            // textBox_eventDescription.Text = currentEvent.description;
            textBox_placeId.Text = currentEvent.place.id + "";
            textBox_placeName.Text = currentEvent.place.name;
            textBox_placeDescription.Text = currentEvent.place.description;

            textBox_organizaerId.Text = currentEvent.organizer.id + "";
            textBox_organizaerName.Text = currentEvent.organizer.name;
            textBox_organizaerDecsription.Text = currentEvent.organizer.description;

            var guestNames = currentEvent.guests.Select(g => g.name);
            listBox_guests.Items.Clear();
            listBox_guests.Items.AddRange(guestNames.ToArray());

            var participantsNames = currentEvent.participants.Select(g => g.name);
            listBox_participants.Items.Clear();
            listBox_participants.Items.AddRange(participantsNames.ToArray());

            comboBox_eventType.DataSource = Enum.GetValues(typeof(EventType));
        }

        private void buttonPrevious_Click(object sender, EventArgs e) {
            if (currentIndex <= 0) return;

            currentEvent = events[--currentIndex];
            drawEvent();
        }

        private void button_next_Click(object sender, EventArgs e) {
            if (currentIndex >= events.Count - 1) return;

            currentEvent = events[++currentIndex];
            drawEvent();
        }

        private void textBox_organizerDescription_TextChanged(object sender, EventArgs e) { }

        private void textBox_eventName_TextChanged(object sender, EventArgs e) {
            currentEvent.name = ((TextBox) sender).Text;
        }

        private void textBox_eventDescription_TextChanged(object sender, EventArgs e) {
            currentEvent.description = ((TextBox) sender).Text;
        }

        private void checkBoxEditPlace_CheckedChanged(object sender, EventArgs e) {
            textBox_placeId.Enabled = ((CheckBox) sender).Checked;
            button_savePlace.Enabled = ((CheckBox) sender).Checked;
        }

        private void button_savePlace_Click(object sender, EventArgs e) {
            updatePlace();
        }

        private async void updatePlace() {
            await HttpClient.GetAsync(_url + "Events/" + currentEvent.id + "/UpdatePlace?placeId=" + newPlaceId);
            loadEvents();
        }

        private void textBox_placeId_TextChanged(object sender, EventArgs e) {
            newPlaceId = Int32.Parse(((TextBox) sender).Text);
        }
    }
}