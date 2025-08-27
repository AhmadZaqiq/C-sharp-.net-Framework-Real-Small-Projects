# C-sharp-.net-Framework-Real-Small-Projects
A collection of real-world small projects developed using C# and .NET Framework.

---

# 1.Stadium Reservation System

## Features

### Team Management and Stadium Booking
- Users can enter team names, book stadiums, start, pause, resume, and end booking periods.
- Buttons are enabled or disabled based on the current state and input validity.

### Dark and Light Mode
- The application offers a dark mode and light mode.
- Colors of the background and text change based on the selected mode, making it user-friendly in different lighting conditions.

### Billing and Price Calculation
- When a booking period ends, the app displays a message with the team's name, total time used, and the calculated price based on the usage duration and rate per minute.

### How to Run
- Navigate to the directory `StadiumReservationSystem/bin/Release`.
- Run `Stadium Reservation System.exe`.

---

# 2.Mini Order System

## Description
This is a **simple Windows Forms application** implemented in C# (.NET Framework) designed as a **training project** to practice the **Publisher-Subscriber pattern** using **custom events**.  

The main goal of this project is to demonstrate how a **UserControl (Publisher)** can raise a **custom event**, and how a **Form (Subscriber)** can subscribe to it and handle the event with its associated data (**EventArgs**).  

## Key Features
- Implements a **custom EventArgs class (`OrderEventArgs`)** to pass data such as product name, quantity, unit price, total price, and timestamp.
- **UserControl raises an event** when the "Process" button is clicked.
- **Form subscribes to the event** to receive the processed order data.
- Displays order information via **MessageBox** and optionally logs it.
- Simple **JSON serialization** for saving and loading orders.
- Provides a clear example of the **Publisher-Subscriber design pattern** in practice.

## Purpose
- To provide a **hands-on example** of raising and subscribing to events in C#.
- To demonstrate **how UserControls can communicate with their parent forms** using events.
- Ideal for **beginners** to understand **event-driven programming** in a Windows Forms environment.

## Technologies Used
- C# (.NET Framework 4.7+)
- Windows Forms
- Newtonsoft.Json (for JSON serialization)

## How to Run
1. Open the solution in **Visual Studio**.
2. Build the project.
3. Run the application.
4. Enter a product name, quantity, and unit price, then click **Send** and **Process**.
5. Observe the event being raised and handled in the form.
6. Optionally, save and load orders via JSON.

