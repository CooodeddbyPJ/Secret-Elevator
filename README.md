<div align="center">

# 🛗 The Secret Elevator
### *Refactored Legacy Edition (v2.0)*

> *System Status: ONLINE* | *Security Level: HIGH*

[![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Console_App-blue?style=for-the-badge&logo=windows-terminal&logoColor=white)](https://dotnet.microsoft.com/)
[![Compatibility](https://img.shields.io/badge/IDE-VS%20%7C%20SharpDevelop-purple?style=for-the-badge)](https://visualstudio.microsoft.com/)

<br />

</div>

## 📌 Mission Briefing
**The Secret Elevator** is a robust C# Console Application that simulates a high-security building transport system.

Originally a *freshman legacy project*, this system has been **completely refactored**. It replaces fragile legacy code (nested if-else chains) with **Dictionary Data Structures** and **O(1) Lookup Logic**, making it crash-proof, scalable, and secure.

---

## 🚀 Key Upgrades (v2.0)

| Feature | Description |
| :--- | :--- |
| **🛡️ Privacy First** | Passwords are now **masked** with asterisks (`***`) using `Console.ReadKey(true)`. |
| **🏗️ Better Logic** | Migrated from spaghetti `if-else` to robust **Dictionaries** for floor management. |
| **🔧 Anti-Crash** | Implemented `int.TryParse` to handle non-numeric inputs gracefully. |
| **🎨 UI Polish** | Added ASCII Art, loading delays (`Thread.Sleep`), and sound cues (`Console.Beep`). |
| **🔄 Loop System** | The program now runs continuously via a `while` loop until manually exited. |

---

## 🔢 Classified Access Codes

<div align="center">

| 🔑 Code | 🏢 Destination | 🔒 Security Clearance |
| :---: | :--- | :---: |
| **135** | First Floor - **Lobby** | LOW |
| **246** | Second Floor - **Research Lab** | MED |
| **357** | Third Floor - **IT Department** | MED |
| **999** | Fourth Floor - **Executive Suite** | HIGH |
| **579** | Fifth Floor - **Rooftop Garden** | HIGH |
| **0** | **BASEMENT** | **RESTRICTED** |

</div>

---

## 📚 Technical Concepts Applied
This project demonstrates mastery of core C# fundamentals:
* **Collections:** `Dictionary<int, string>` for efficient state management.
* **Input Validation:** Preventing runtime errors with defensive coding.
* **Console UX:** Manipulating cursor visibility and text feedback.
* **Threading:** Simulating real-world delays using `System.Threading`.

---

## 🖥️ Terminal Preview

```text
      __________________
     |  ______________  |
     | |              | |
     | |    SECRET    | |
     | |   ELEVATOR   | |
     | |              | |
     | |______________| |
     |__________________|

[ SYSTEM LOCKED ]
Enter Access Code: ***

Verifying identity...
█▒▒▒▒▒▒▒▒▒

ACCESS GRANTED.
Transporting to: Fifth Floor - Rooftop Garden
Going up.....

*Ding!* You have arrived.
