@startuml
loop
    Mitarbeiter -> Kunde: Nihmt bestellung auf
    Mitarbeiter -> Server: Erstelle Bestellung
    Küche -> Mitarbeiter: Bestellung zubereitet
    Mitarbeiter -> Kunde: Bestellung serviert
end
Kunde -> Mitarbeiter: Zeigt sich bereit zu zahlen
Mitarbeiter -> Kunde: Rechung getrennt?
Mitarbeiter -> Server: Erstelle Rechnung
Mitarbeiter -> Server: Ducke Rechung
Mitarbeiter -> Kunde: Gib Kunden die Rechnung
Kunde -> Mitarbeiter: Bezahlt Rechnung mit Trinkgeld
Mitarbeiter -> Kunde: Gibt Wechselgeld
Mitarbeiter -> Server: Archiviere Rechnung
@enduml