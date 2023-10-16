@startuml
Kunde -> Mitarbeiter: Bittet um Tisch
Mitarbeiter -> Server: Suche freie Tische
alt freie Tische
    Server -> Mitarbeiter: Zeigt freie Tische
    Mitarbeiter -> Server: Weise freien Tisch X zu
    Server -> Mitarbeiter: Freier Tisch X zugewiesen
    Mitarbeiter -> Kunde: Führe Kunden an Tisch X
else keine freien Tische
    Mitarbeiter -> Kunde: Kunden sagen das kein Tisch frei ist
end
@enduml