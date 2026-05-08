# Health Guardian 🏥
---

## 🌟 Overview
Many elderly people face a common challenge: difficulty in remembering medication schedules, leading to serious health risks and constant anxiety for their families. 

This project is far from being a basic reminder app; it is a comprehensive **Healthcare Support Solution** built using **C#** and **Windows Forms**. It acts as a bridge between patients and their loved ones, automating the entire care cycle—from tracking precise dosages to monitoring pill counts—ensuring that treatment is never missed and families are always kept in the loop through real-time notifications.
## ✨ Key Features
* **Missed-Dose Notifications:** Automatically alerts relatives via email if a scheduled dose is skipped.
* **Smart Low-Stock Email Alerts:** Beyond simple on-screen notifications, the system automatically sends an email to relatives the moment the medicine count reaches 5 pills.
* **Weekly Compliance Reports:** Generates structured data to track medication adherence over time.
* **Visual Architecture:** Includes a professional Class Diagram representing the system’s modular design.

## 📁 Project Structure
The project follows a modular architecture to separate time-tracking, communication, and data management:

* **`Timer.cs`**: The dedicated engine for time-tracking. It handles the **background timers** and real-time monitoring to ensure alerts are triggered at the exact scheduled moments.
* **`MedicineManager.cs`**: Acts as the central controller for inventory logic. It tracks pill counts and checks them against the **safety threshold** to identify when restocking is needed.
* **`Email.cs`**: The communication service that integrates with **SMTP servers** to instantly notify family members about missed doses or low stock (below 5 pills).
* **`HealthGurdain.cs` & `Medecine.cs`**: Dedicated to maintaining data integrity and defining the core medical entities.
## 📧 Email Configuration (Security Note)
To maintain security, personal credentials have been removed. To use the notification feature:
1. Open `Email.cs`.
2. Locate `SenderEmail` and `AppPassword`.
3. **Requirement:** Generate an **App Password** from your Google Account security settings.
4. Replace the placeholders with your own email and the generated App Password.

## 🛠️ Requirements & Setup
To run this project locally, make sure you have the following installed:
* **Visual Studio** (2019 or newer recommended).
* **.NET Framework** (Compatible version for Windows Forms).
* **SMTP Configuration:** To enable the Email Alert feature, you need to configure your email credentials in the `Email.cs` file.

