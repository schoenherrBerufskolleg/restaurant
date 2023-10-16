# **\<Ihr Logo\>**



# Historie der Dokumentversionen

| **Version** | **Datum** | **Autor** | **Änderungsgrund / Bemerkungen** |
| --- | --- | --- | --- |
| 1.0 | 25.09.2023 | Ben Schönherr, Maik Bösert |  |
# Inhaltsverzeichnis


# 1 Einleitung

Die folgende Dokumentation definiert die Anforderungen und Funktionen für die Entwicklung einer C#-Anwendung zur Verwaltung von Bestellungen und Abrechnungen in einem Restaurant. Das System soll den Mitarbeitern im Service bei der Bestellannahme, Tischzuweisung, Abrechnung und Berichterstellung unterstützen.

## 1.1 Allgemeines

Dieses Pflichtenheft basiert auf der Vorlage von [projectmanagement-freeware.de](https://projektmanagement-freeware.de/software/word-vorlage-pflichtenheft/)

### 1.1.1 Zweck und Ziel dieses Dokuments

Dieses Dokument soll formal festhalten wie dieses Projekt durchgeführt werden soll, was das Ziel ist und welche Kosten eventuell anfallen.

### 1.1.2 Projektbezug

Dieses Dokument beschreibt die Anforderungen und Spezifikationen für die Entwicklung einer C#-Anwendung zur Verwaltung von Bestellungen und Abrechnungen in einem Restaurant.

### 1.1.3 Abkürzungen

* GUI: Graphical User Interface
* C#: Programmiersprache C Sharp

### 1.1.4 Ablage, Gültigkeit und Bezüge zu anderen Dokumenten

Dieses Pflichtenheft dient als Grundlage für die Entwicklung der Restaurant-Management-Anwendung. Es sollte in Verbindung mit anderen Projektunterlagen wie dem Lastenheft und den Meeting-Protokollen verwendet werden.

## 1.2 Reviewvermerke und Meeting-Protokolle

# 2 Konzept und Rahmenbedingungen

Grundlegende Konzepte und Rahmenbedingen wurden bereits im ausgeschriebenen Autrag spezifiziert.

## 2.1 Ziele des Anbieters

Das Ziel des Anbieters ist die Entwicklung einer effizienten Restaurant-Management-Anwendung, die die Bestellungs- und Abrechnungsprozesse optimiert.

## 2.2 Ziele und Nutzen des Anwenders

Das Restaurant möchte durch die Anwendung eine bessere Bestellungsverwaltung, Tischzuweisung und Umsatzverfolgung erreichen, um den Service zu verbessern und die Kundenzufriedenheit zu steigern.

## 2.3 Benutzer / Zielgruppe

Die Benutzer der Anwendung sind die Mitarbeiter des Restaurants, darunter Kellner, Köche und Manager.

## 2.4 Systemvoraussetzungen

Die Anwendung erfordert Windows-basierte Computer mit ausreichender Hardware und eine Datenbank zur Speicherung von Informationen.

## 2.5 Ressourcen

Die Ressourcen für das Projekt umfassen Entwickler, Tester, Hardware und Softwarelizenzen. Wir werden zwei Entwickler mit der Entwicklung der Software beauftragen. Um die Software zu entwickeln werden ebenfalls zwei Entwickler Arbeitsplätze, sowie zwei Visual Studio Lizenzen benötigt.

## 2.6 Übersicht der Meilensteine

**Vorbereitungsphase**
* Modellierung der Datenbank
* Modellierung der Geschäftslogik
* Freigabe Pflichtenheft

**Implementierung und Test**
* Aufbau der Authentifizierung
* Feature "Tisch Zuweisen/Ändern"
* Feature "Bestellen und Abrechnen"
* Fertigstellen der visuellen Präsentation

* **Inbetriebnahme**
* Testbetrieb Abgeschlossen
* Produktiv Testphase Abgeschlossen

## 3.1 Anforderung

### **Allgemeine Anforderungen**

- Das System muss in C# entwickelt werden und auf Windows-basierten Rechnern lauffähig sein.
- Das System sollte eine benutzerfreundliche grafische Benutzeroberfläche (GUI) aufweisen.

### **Getränke- und Speisekarte**

- Das System muss eine Getränkekarte und eine Speisekarte verwalten.
- Die Speisekarte muss mindestens 30 Gerichte inklusive Desserts enthalten.
- Die Getränkekarte muss die gängigen Getränkeoptionen eines Restaurants enthalten.

### **Mitarbeiterverwaltung**

-  Mehrere Mitarbeiter/innen müssen sich im System identifizieren können.
-  Jeder Mitarbeiter muss eindeutig identifizierbar sein, z.B. durch einen Benutzernamen und ein Passwort.

### **Tischverwaltung**

- Das System muss die Anordnung von mindestens 25 Tischen in einer Übersicht darstellen können.
- Mitarbeiter/innen müssen die Tische für Bestellungen und Abrechnungen auswählen können, indem sie die Tische in der Übersicht anklicken.
- Es muss möglich sein, einen Tisch jederzeit einem anderen Mitarbeiter/einer Mitarbeiterin zuzuweisen.
- Tische können entweder als Gruppe oder einzeln zugeordnet werden.

### **Bestellungsverwaltung**

- Mitarbeiter/innen müssen Bestellungen aufnehmen können, wobei Besonderheiten wie Zusatzanforderungen (z.B. Salat extra oder keine Tomaten) berücksichtigt werden können.
- Die Möglichkeit, Bestellungen zu ändern oder zu stornieren, muss gegeben sein.

### **Abrechnung**

- Die Abrechnung eines Tisches kann sowohl als Gesamtrechnung als auch mit getrennten Rechnungen erfolgen.
- Die Darstellung der getrennten Rechnungen muss übersichtlich und transparent sein.
- Der bezahlte Betrag muss gespeichert werden.
- Rechnungen müssen ausgedruckt werden können.

### **Umsatz- und Trinkgeldverwaltung**

- Der Betrag einer abgerechneten Rechnung muss dem Umsatz des zuständigen Mitarbeiters/der zuständigen Mitarbeiterin zugeschrieben werden.
- Das Trinkgeld muss ebenfalls erfasst und zugeordnet werden.
- Für einen Arbeitstag müssen sowohl der Umsatz der einzelnen Mitarbeitenden als auch die Gesamtsumme angezeigt werden.

### **Optionale Anforderungen**

- Erstellung einer Anzeige für die Getränke- und Speisenzubereitung in der Theke bzw. Küche, basierend auf den am Tisch entgegengenommenen Bestellungen.

### 3.1.1 Beschreibung

Die Anwendung muss die Möglichkeit bieten, Bestellungen aufzunehmen, zu ändern oder zu stornieren. Dabei müssen Besonderheiten wie Zusatzanforderungen berücksichtigt werden können.

### 3.1.2 Wechselwirkungen

Die Wechselwirkungen zwischen den Mitarbeitern und dem im Rahmen dieses Projekts entstehenden Programm sind von entscheidender Bedeutung für den reibungslosen Ablauf der Restaurantbetriebsabläufe. Das Programm wird als zentrales Werkzeug dienen, mit dem die Mitarbeiter interagieren, um Bestellungen entgegenzunehmen, Tische zuzuweisen und Abrechnungen durchzuführen. Diese Interaktionen sind vielfältig und eng miteinander verknüpft.

### 3.1.3 Risiken

Die Hauptrisiken sind Fehler in der Bestellungsverwaltung, die zu falschen Bestellungen führen könnten. Eng daran geknüpft wäre eine fehlerhafte Abrechnung welche ebenfalls ein großes Risiko darstellt.

### 3.1.4 Testhinweise

Es müssen umfangreiche Tests durchgeführt werden, um sicherzustellen, dass die Bestellungsverwaltung und die Abrechnung korrekt funktioniert.

### 3.1.5 Vergleich mit bestehenden Lösungen

Behandlung der Bestellungen und Abrechnungen wird aktuell vollständig manuell mit Stift und Papier umgesetzt. Dies führt zu falschen Rechnungen und vergessenen Bestellungen. 
Die Anwendung soll die manuelle Bestellungsverwaltung ersetzen und effizientere Abläufe ermöglichen.

### 3.1.6 Grobschätzung des Aufwands

Die Entwicklung dieser Funktion wird voraussichtlich insgesamt 24 Arbeitsstunden auf 3 Wochen verteilt in Anspruch nehmen.

# 4 Anhang / Ressourcen

\<Ihr Text\>
