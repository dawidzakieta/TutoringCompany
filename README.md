Program został stworzony w języku C#. Prezentuje aplikację do zarządzania prywatnym przedsiębiorstwem świadczącym usługi korepetycji. 
Aplikacja została zaimplementowana w języku C z użyciem technologii Windows Presentation Foundation (WPF) do tworzenia interfejsu graficznego. 

Autorzy: Dawid Żakieta & Kacper Grabowski

Poniżej przedstawiamy podsumowanie różnych aspektów tego programu:

Funkcje Aplikacji:

1. Zarządzanie Klientami:
   - Dodawanie nowych klientów.
   - Usuwanie istniejących klientów.
   - Sortowanie listy klientów.
2. Zarządzanie Korepetytorami:
   - Dodawanie nowych nauczycieli.
   - Usuwanie istniejących nauczycieli.
   - Sortowanie listy nauczycieli.
3. Zarządzanie Studentami:
   - Dodawanie nowych studentów.
   - Usuwanie istniejących studentów.
   - Sortowanie listy studentów.
   - Przypisywanie klientów i nauczycieli do studentów.
4. Zarządzanie Lekcjami:
   - Dodawanie nowych lekcji z wyborem studenta.
   - Usuwanie istniejących lekcji.
   - Sortowanie listy lekcji.

Funkcje Dodatkowe:

- Zapis i Odczyt z Pliku:
  - Program umożliwia zapisywanie danych do plików w formacie JSON.
  - Przy ponownym uruchomieniu, wczytuje dane zapisane wcześniej.
- Interfejs Graficzny:
  - Wykorzystuje technologię WPF do tworzenia intuicyjnego interfejsu graficznego.
  - Każde okno posiada niestandardowy pasek tytułowy z przyciskami minimalizacji i zamknięcia.

- Wyszukiwanie i Filtracja:
  - W każdej sekcji istnieje możliwość wyszukiwania po imieniu, nazwisku, numerze telefonu itp.
  - Funkcje filtrowania pomagają szybko odnaleźć potrzebne informacje.
- Obsługa Błędów:
 - Program zawiera obsługę błędów, która informuje użytkownika o nieprawidłowych danych lub operacjach.

Opis Kluczowych Klas:
 
- ClientList, TutorList, StudentList, LessonList:
  - Klasy reprezentujące listy klientów, nauczycieli, studentów i lekcji.
  - Posiadają metody do dodawania, usuwania i sortowania.
- AddClient, AddTutor, AddStudent, AddLesson:
  - Okna służące do dodawania nowych klientów, nauczycieli, studentów i lekcji.
- Clients, Tutors, Students, Lessons:
  - Okna główne do zarządzania klientami, nauczycielami, studentami i lekcjami.
- MainWindow:
  - Główne okno programu, inicjalizujące listy i obsługujące nawigację między różnymi sekcjami.

Podsumowanie:
 
Program jest aplikacją do zarządzania firmą korepetorską, oferującą intuicyjny interfejs graficzny i funkcje umożliwiające kontrolę nad klientami, nauczycielami, studentami i lekcjami. Działa w oparciu o zasadę obiektowości i wykorzystuje funkcje języka C oraz technologii WPF, aby dostarczyć użytkownikowi efektywne narzędzie do efektywnego prowadzenia biznesu.

Co jeszcze planujemy wdrożyć:

- możliwość edytowania klientów, korepetytorów, studentów, lekcji
- połączenie z bazą danych sql
- stworzenie interaktywnego kalendarza do wybierania daty i godziny zajęć
- stworzenie klas przechowujących faktury i płatności, szeroko pojętą ewidencję środków
- usprawnienie i redukcja kodu do potrzebnego minimum (powtarzanie się kodu, pisany nieefektywnie)
- inne rzeczy, o których jeszcze nie pomyśleliśmy 😉
