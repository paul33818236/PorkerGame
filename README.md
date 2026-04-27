# 🃏 Poker Game with Betting System (C# WinForms)

This project is a **Five-Card Poker Game** developed using **C# Windows Forms**, enhanced with a **betting system** that calculates rewards based on hand rankings and payout odds.

---

## 📖 Project Overview

This application simulates a simplified poker game where players can:

- Draw 5 random cards
- Change selected cards
- Evaluate hand rankings
- Place bets and receive payouts

The system integrates **game logic + financial calculation**, providing both entertainment and practical programming experience.

---

## 🖥️ User Interface

<img width="1417" height="1026" alt="image" src="https://github.com/user-attachments/assets/5e737cb5-e84f-4506-9750-3f8e91161f32" />

<img width="1412" height="1029" alt="image" src="https://github.com/user-attachments/assets/fbd6fb34-7689-4ef7-aa2a-7533688176f5" />
---

## ⚙️ Features

### 🃏 Poker System
- Random card dealing (5 cards)
- Card replacement (draw phase)
- Hand evaluation:
  - Royal Flush
  - Straight Flush
  - Four of a Kind
  - Full House
  - Flush
  - Straight
  - Three of a Kind
  - Two Pair
  - One Pair
  - High Card

---

### 💰 Betting System (Core Requirement)

- Player can input a **bet amount**
- System deducts bet from total balance
- After evaluating the hand:
  - Rewards are calculated based on **payout odds**
  - Winning amount is added back to player balance

---

## 🎰 Payout Table

| Hand Type        | Odds |
|----------------|------|
| Royal Flush     | 250  |
| Straight Flush  | 50   |
| Four of a Kind  | 25   |
| Full House      | 9    |
| Flush           | 6    |
| Straight        | 4    |
| Three of a Kind | 3    |
| Two Pair        | 2    |
| One Pair        | 1    |
| High Card       | 0    |

---

## 🧠 Design Highlights

### 🔹 Separation of Logic and Display
To avoid incorrect payout calculation, the program separates:
- **Display result (with card values/suits)**
- **Hand type (used for odds calculation)**

---

### 🔹 Input Validation
- Prevents invalid bet input
- Ensures bet does not exceed total balance
- Handles non-numeric input safely

---

### 🔹 Game Flow

1. Enter bet amount
2. Click **Bet**
3. Draw cards
4. Replace cards (optional)
5. Click **Check**
6. Evaluate hand
7. Calculate payout
8. Update total balance

---

## 🛠️ Technologies Used

- Language: **C#**
- Framework: **.NET WinForms**
- IDE: **Visual Studio**

---

## 🚀 How to Run

1. Open the project in Visual Studio
2. Build and run (F5)
3. Enter bet amount
4. Play the game using:
   - Deal
   - Change cards
   - Check result

---



