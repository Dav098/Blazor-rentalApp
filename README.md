# 🚗 Blazor RentalApp

![Blazor](https://img.shields.io/badge/Web-Blazor%20WebAssembly%20%2F%20Server-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

**Blazor RentalApp** to nowoczesna aplikacja webowa służąca do zarządzania procesem wynajmu (np. pojazdów, mieszkań lub sprzętu), stworzona przy użyciu frameworka **Blazor** oraz platformy **.NET**. Projekt łączy w sobie intuicyjny interfejs użytkownika z potężnym zapleczem programistycznym, zapewniając płynne działanie oraz pełną responsywność[cite: 1].

---

## 🚀 Funkcje aplikacji

### 👤 Panel Użytkownika (Klienta)
* **Przeglądanie oferty:** Interaktywna lista dostępnych obiektów/pojazdów do wynajęcia z zaawansowanym filtrowaniem i sortowaniem[cite: 1].
* **Szczegóły przedmiotu:** Dedykowany widok z pełnym opisem, galerią zdjęć, specyfikacją oraz cennikiem[cite: 1].
* **System rezerwacji:** Intuicyjny formularz wyboru dat (kalendarz) oraz automatyczne wyliczanie kosztu całkowitego[cite: 1].
* **Historia zamówień:** Podgląd bieżących, zrealizowanych oraz anulowanych rezerwacji[cite: 1].
* **Profil użytkownika:** Zarządzanie danymi osobowymi oraz ustawieniami konta[cite: 1].

### 🔑 Panel Administratora
* **Zarządzanie asortymentem:** Dodawanie, edycja oraz usuwanie przedmiotów przeznaczonych na wynajem (CRUD)[cite: 1].
* **Obsługa rezerwacji:** Akceptowanie, odrzucanie oraz modyfikacja statusów zamówień klientów[cite: 1].
* **Zarządzanie użytkownikami:** Podgląd listy zarejestrowanych osób oraz nadawanie uprawnień (np. Rola Admin / Moderator)[cite: 1].
* **Statystyki i raporty:** Prosty dashboard prezentujący przychody oraz najpopularniejsze przedmioty[cite: 1].

---

## 🛠️ Tech Stack

* **Frontend:** Blazor (WebAssembly lub Server), HTML5, CSS3, Bootstrap / MudBlazor (w zależności od użytej biblioteki UI)[cite: 1].
* **Backend (API):** ASP.NET Core Web API (jeśli projekt jest rozbity na architekturę klient-serwer)[cite: 1].
* **Baza danych:** Entity Framework Core (SQL Server / PostgreSQL / SQLite)[cite: 1].
* **Autentykacja:** ASP.NET Core Identity / JWT Tokens[cite: 1].

---

## 📸 Zrzuty ekranu

> *Miejsce na zrzuty ekranu Twojej aplikacji. Możesz je dodać, wrzucając zdjęcia do folderu np. `screenshots/` w repozytorium.*[cite: 1]

| Strona Główna / Katalog | Panel Rezerwacji |
| :---: | :---: |
| ![Katalog](https://via.placeholder.com/400x250?text=Katalog+Produkt%C3%B3w) | ![Rezerwacja](https://via.placeholder.com/400x250?text=Formularz+Rezerwacji) |

---

## 💻 Uruchomienie projektu lokalnie

### Wymagania wstępne
Przed uruchomieniem upewnij się, że masz zainstalowane:
* [.NET SDK 8.0](https://dotnet.microsoft.com/download) (lub wersję zgodną z Twoim projektem)[cite: 1]
* IDE (np. [Visual Studio 2022](https://visualstudio.microsoft.com/vs/), [JetBrains Rider](https://www.jetbrains.com/rider/) lub [VS Code](https://code.visualstudio.com/))[cite: 1]
* Serwer bazy danych (np. SQL Server LocalDB)[cite: 1]

### Instrukcja krok po kroku

1.  **Sklonuj repozytorium:**
    ```bash
    git clone [https://github.com/Dav098/Blazor-rentalApp.git](https://github.com/Dav098/Blazor-rentalApp.git)
    cd Blazor-rentalApp
    
```[cite: 1]

2.  **Konfiguracja bazy danych (Entity Framework):**
    Otwórz plik `appsettings.json` w projekcie serwerowym/API i dostosuj `ConnectionString` do swojej lokalnej bazy danych, a następnie wykonaj migrację:
    ```bash
    dotnet ef database update
    
```[cite: 1]

3.  **Uruchomienie aplikacji:**
    Przejdź do katalogu głównego projektu i uruchom polecenie:
    ```bash
    dotnet run
