<div align="center">

# 🛗 The Secret Elevator
### *Refactored Legacy Edition (v2.0)*

> *System Status: ONLINE* | *Security Level: HIGH*

[![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Console_App-blue?style=for-the-badge&logo=windows-terminal&logoColor=white)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-success?style=for-the-badge)](https://opensource.org/licenses/MIT)

<br />

</div>

## 📌 Mission Briefing
**The Secret Elevator** is a robust C# Console Application that simulates a high-security building transport system.

Originally a *freshman legacy project*, this system has been **completely refactored** to demonstrate professional coding standards. It replaces fragile legacy code (long nested `if-else` chains) with **Dictionary Data Structures** and **O(1) Lookup Logic**, making the system crash-proof, scalable, and secure.

---

## 🚀 Key Upgrades (v2.0)

| Feature | Description |
| :--- | :--- |
| **🛡️ Secure Input** | Passwords are now **masked** with asterisks (`***`) using `Console.ReadKey(true)` so onlookers cannot see the code. |
| **🏗️ Data Structures** | Migrated from spaghetti code to robust **Dictionaries** for efficient floor management. |
| **🔧 Crash-Proof** | Implemented `int.TryParse` to handle non-numeric inputs gracefully (no more crashing if you type letters!). |
| **🎨 UI Polish** | Added custom ASCII Art, loading delays (`Thread.Sleep`), and sound cues (`Console.Beep`) for immersion. |
| **🔄 Continuous Loop** | The program now runs continuously via a `while` loop until manually exited. |
| **📱 Compatibility** | Optimized to run smoothly on **SharpDevelop**, **VS Code**, and **Visual Studio**. |

---

## 🔢 Classified Access Codes

Use these codes to navigate the facility. **Authorized Personnel Only.**

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
This project serves as a demonstration of core C# mastery:
* **Collections:** Using `Dictionary<int, string>` for cleaner state management.
* **Input Validation:** Error handling using `TryParse` to prevent runtime exceptions.
* **Console Manipulation:** Controlling cursor visibility and text feedback for a better UX.
* **Threading:** Utilizing `System.Threading` to simulate real-world elevator travel time.
* **Refactoring:** The process of converting legacy code into modular, maintainable logic.

---
## 🛠️ How to Run

1.  **Clone the Repository**
    Open your terminal or command prompt and run:
    ```bash
    git clone [https://github.com/CooodeddbyPJ/The-Secret-Elevator.git](https://github.com/CooodeddbyPJ/The-Secret-Elevator.git)
    ```

2.  **Open the Project**
    Launch **Visual Studio**, **VS Code**, or **SharpDevelop**.

3.  **Run**
    Compile and execute `Program.cs`.

4.  **Play**
    Enter a secret code from the table above.

---

<div align="center">

### 👤 Author

## **PJ | Full Stack Dreamer**
*Refactoring the future, one line at a time.*

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/CooodeddbyPJ)

</div>
