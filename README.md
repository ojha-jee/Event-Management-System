<h1 align="center">🎉 Event Management System 🎉</h1>
<p align="center">
  A robust, modern web application to manage and register for events — built with ASP.NET MVC (.NET 4.8) , Identity, and EF Core.
</p>

<p align="center">
<img src="https://img.shields.io/badge/.NET%20Framework-4.8-blue?logo=windows" />
 <img src="https://img.shields.io/badge/Entity%20Framework-6.0-green?logo=database" />

  <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg" />
  <img src="https://img.shields.io/badge/UI-Bootstrap-blueviolet?logo=bootstrap" />
</p>

---

## 🚀 Overview

The **Event Management System (EMS)** is a full-stack web application that enables:

- 👨‍💼 **Admins** to create, edit, delete, and manage events and view registered users.
- 🙋‍♂️ **Users** to register, browse available events, register or cancel registration.
- 📧 Built-in email simulation on registration and event signup.
- 📊 Admin dashboard with DataTables and analytics.

---

## ✨ Key Features

### 🔐 Authentication & Roles
- ✅ **User Registration** with fields: First Name, Last Name, Email, Age, Contact Number
- 🔐 **Role-Based Access**: Admin / User
- 📧 **Email Confirmation** (simulated)
- 🔑 Secure Login/Logout using ASP.NET Core Identity
- 🧑‍💼 Seeded Admin: `admin@ems.com / Admin@123`

---

### 📅 Admin Event Management
- 🗂 CRUD operations on events
- 📊 DataTables integration for event listing
- 🔍 Server-side search & pagination
- 👥 View registered users for each event with details
- 🖼 Event fields: Title, Description, Location, Start/End DateTime, Capacity, Image URL

---

### 🎟️ User Event Registration
- 🧾 Register for upcoming events
- 🧠 One-time registration check
- 🔄 Cancel registrations anytime
- 🔎 Search by Event Name & Location
- 💼 "My Events" page to manage user registrations
- 📋 Modal-based registration form with prefilled email/contact

---

### 📧 Email Notifications
- 📬 Email confirmation after registration
- 📨 Notification with event details on event signup
- 💡 Simulated with `InMemoryEmailSender`

---

### 🌱 Seed Data
- 👤 Seeded Admin Account:  
  `admin@ems.com` / `Admin@123`
- 📅 5 Sample Events inserted during initial migration

---

## 🛠️ Tech Stack
| Technology               | Usage                                      |
|--------------------------|--------------------------------------------|
| ASP.NET MVC (.NET 4.8)   | Web framework                              |
| Entity Framework 6       | ORM with Code First                        |
| ASP.NET Identity         | Role-based Authentication & Authorization  |
| Bootstrap 5              | UI Styling                                 |
| jQuery + DataTables      | Admin Tables, Search, Pagination           |
| LINQ                     | Data Queries                               |
| Modal Forms              | User Event Registration                    |
| Repository Pattern       | Clean Architecture                         |

---

---

## 📸 UI Snapshots (Coming Soon)

> Add screenshots of:
> - Login Page
> - Admin Dashboard
> - Event Registration Modal
> - My Events Page

---

## 🧪 Getting Started

```bash
# Clone the repository
git clone https://github.com/ojha-jee/event-management-system.git

# Open solution in Visual Studio

# Run migrations
Update-Database

# Start the app and visit http://localhost:<port>
