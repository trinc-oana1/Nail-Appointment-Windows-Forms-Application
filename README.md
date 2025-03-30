# Nail Appointment - Windows Forms Application
This is a Windows Forms application built in C#, designed to suggest a nail design and allow users to schedule an appointment.

After logging in with a predefined username and password, the user can generate a personalized nail design suggestion by selecting the following features:

- Length: short, medium, or long

- Shape: square, oval, or almond

- Color: black, white, or red

- Design: simple or glitter

- Finish: matte or glossy

Once the options are selected, the user can press the "Generate" button to receive a suggestion from a predefined set of images.

The "Book Appointment" button opens a pop-up form where the user can choose a date, hour, and minute for the appointment. After confirmation, a pop-up message displays the selected appointment details.

All appointments are automatically saved to a text file along with the user’s login information and selected nail design.

Used Controls:

- Label: for explanatory texts and the confirmation message

- TextBox: for entering the username and password

- TrackBar: for selecting nail length

- RadioButton inside GroupBox: for selecting shape and finish

- ListBox: for selecting color and design

- PictureBox: for displaying the logo and suggestion images

- Button: for triggering various actions

- MonthCalendar: for choosing the appointment date

- ComboBox: for selecting the hour and minute

- MessageBox: for displaying errors
