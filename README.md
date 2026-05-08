# Health Guardian 🏥
---

## 🌟 Overview
This project is far from being just a basic medication reminder or a simple medicine logging app. Unlike standard applications that only provide notifications, this system is a comprehensive **Healthcare Support Solution** built to bridge the gap between patients and their families.

Developed using **C#** and **Windows Forms**, it offers a high level of control that goes beyond simple alerts. It manages the entire medication cycle—from tracking precise dosages and pill counts to generating weekly adherence sheets. Most importantly, it keeps the family connected through automated email alerts, ensuring that care is a shared responsibility, not just a solo task.

## ✨ Key Features
* **Smart Emergency Alerts:** Automatically sends email updates to relatives if a patient misses their scheduled dose, ensuring immediate awareness.
* **Low Stock Notifications:** The system monitors pill counts in real-time and alerts the family as soon as the quantity drops below **5 pills**, allowing for timely restocking.
* **Beyond Simple Reminders:** Manages complex scheduling, dosages, and inventory levels in one integrated dashboard.
* **Weekly Performance Sheets:** Generates detailed reports to track medication consistency over the week for medical review.
* **Modular OOP Architecture:** Built with professional classes like `MedicineManager` and `HealthGurdain` for maximum reliability.

## 📁 Project Structure
The project follows a modular architecture to separate time-tracking, communication, and data management:

* **`Timer.cs`**: The dedicated engine for time-tracking. It handles the **background timers** and real-time monitoring to ensure alerts are triggered at the exact scheduled moments.
* **`MedicineManager.cs`**: Acts as the central controller for inventory logic. It tracks pill counts and checks them against the **safety threshold** to identify when restocking is needed.
* **`Email.cs`**: The communication service that integrates with **SMTP servers** to instantly notify family members about missed doses or low stock (below 5 pills).
* **`HealthGurdain.cs`**: Focuses on data integrity and specialized patient monitoring protocols.
* **`Medecine.cs`**: The core data model that defines the attributes of each medication and its dosage requirements.
* 
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

