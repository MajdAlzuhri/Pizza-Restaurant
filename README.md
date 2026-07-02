# 🍕 Pizza Restaurant Ordering System
C# | Windows Forms | Object-Oriented Programming | Event-Driven Programming

---

## 📖 Introduction

This project demonstrates how to build a complete **Pizza Restaurant Ordering System** using **C# Windows Forms**.

The application allows customers to customize their pizza by selecting the size, crust type, toppings, and dining option while automatically calculating the total price and displaying a live order summary.

The goal is not just to create a graphical interface —
but to understand how event-driven desktop applications are designed using Object-Oriented Programming principles.

This project serves as a practical introduction to GUI development and user interaction in Windows Forms.

---

## 🎯 Project Goals

- Build an interactive Pizza Ordering System using Windows Forms
- Allow users to fully customize their pizza
- Calculate the total price automatically
- Display a live order summary
- Validate and confirm customer orders
- Apply Object-Oriented Programming concepts
- Practice Event-Driven Programming
- Design an intuitive graphical user interface

---

## 🧠 Core Concepts Applied

- C#
- Windows Forms (WinForms)
- Object-Oriented Programming (OOP)
- Event-Driven Programming
- Methods & Functions
- Conditional Statements
- Data Validation
- Modular Design
- User Interface Design
- Code Reusability

---

## 🏗 Project Design Philosophy

The application is designed to simulate a real pizza ordering system.

✔ Customers can customize every part of their pizza

✔ Every change immediately updates the order summary

✔ The total price is calculated dynamically

✔ Orders can be confirmed and locked after submission

The design emphasizes:

- User-friendly interface
- Clean separation of responsibilities
- Reusable helper methods
- Real-time feedback
- Maintainable and scalable code

Most application behavior is built around reusable update methods instead of duplicating logic.

---

## Project Previwe
<img width="1201" height="807" alt="image" src="https://github.com/user-attachments/assets/34421955-2afb-4edd-a006-f7cab74adf30" />

<img width="1260" height="780" alt="image" src="https://github.com/user-attachments/assets/4aab26ca-246a-446a-8d72-9bb68d5b827b" />


## 🧩 Implemented Features

### 🔹 Pizza Size

- Small
- Medium
- Large

---

### 🔹 Crust Type

- Thin Crust
- Thick Crust

---

### 🔹 Toppings

- Extra Cheese
- Onion
- Mushrooms
- Olives
- Tomatoes
- Green Peppers

Multiple toppings can be selected simultaneously.

---

### 🔹 Dining Options

- Eat In
- Take Away

---

### 🔹 Order Summary

Displays:

- Selected Size
- Selected Toppings
- Crust Type
- Dining Option
- Total Price

The summary updates automatically whenever the user changes any option.

---

### 🔹 Price Calculation

The application calculates the total price based on:

- Pizza Size
- Crust Type
- Selected Toppings

All calculations are performed dynamically without requiring additional user actions.

---

### 🔹 Order Management

- Place Order
- Order Confirmation
- Reset Order
- Disable editing after confirmation

---

## 🧪 Example Usage

### Select Pizza Size

```csharp
rbLarge.Checked = true;
```

---

### Select Toppings

```csharp
chkExtraChees.Checked = true;
chkOlives.Checked = true;
chkMushrooms.Checked = true;
```

---

### Select Crust

```csharp
rbThin.Checked = true;
```

---

### Select Dining Option

```csharp
rbEatIn.Checked = true;
```

---

### Place Order

```csharp
btnOrderPizza.PerformClick();
```

---

### Reset Order

```csharp
btnReset.PerformClick();
```

---

## 🧠 What This Project Teaches

By building this project, you gain experience with:

- Windows Forms development
- Event handling
- Interactive GUI design
- Object-Oriented Programming
- Dynamic price calculation
- User input validation
- Modular programming
- Writing maintainable desktop applications

This shifts your mindset from:

Creating static interfaces

to

Developing fully interactive desktop applications

---

## ⚖ Manual Ordering vs Automated Ordering

| Aspect | Manual Ordering | Pizza Ordering System |
|---------|-----------------|-----------------------|
| Price Calculation | Manual | Automatic |
| Order Summary | Written manually | Updated instantly |
| Validation | Human-dependent | Program-controlled |
| User Experience | Slower | Faster |
| Accuracy | May contain errors | Consistent |

Automating the ordering process improves both speed and reliability.

---

## 🔄 Architectural Pattern Used

This project follows a **Modular Event-Driven** architecture.

Core helper methods are responsible for updating different parts of the application.

### Examples

- `UpdateOrderSummary()` → updates the complete summary
- `UpdateSize()` → updates selected pizza size
- `UpdateCrust()` → updates crust type
- `UpdateToppings()` → updates selected toppings
- `UpdateWhereToEat()` → updates dining option
- `UpdateTotalPrice()` → recalculates the total order price
- `CalculateTotalPrice()` → combines all pricing logic

Each UI event simply calls the appropriate update method, keeping the code clean, organized, and easy to maintain.

Programming here is treated like building reusable components that work together seamlessly.

---

## 🛠 Technologies

- C#
- .NET Framework
- Windows Forms (WinForms)
- Object-Oriented Programming (OOP)
- Event-Driven Programming
- Visual Studio
- Desktop Application Development

---

## 📷 Project Preview

### Home Screen

- Attractive restaurant landing page
- Order Now button to start customization

### Order Details Screen

- Pizza size selection
- Crust selection
- Multiple toppings
- Dining option
- Live order summary
- Automatic price calculation
- Order confirmation and reset functionality

---

## 🚀 Future Improvements

- Save orders to a database
- Customer information form
- Delivery option
- Multiple pizza orders
- Drinks and side menu
- Discount coupons
- Receipt generation
- Order history
- Payment integration
- Admin dashboard
- Sales reports

This project provides a solid foundation for developing a complete restaurant management system.
