@startuml WaterfallModel

!define BoxStyle rounded
!define ArrowStyle thick

skinparam monochrome true

box "Requirements" #LightBlue
end box

box "Design" #LightGreen
end box

box "Implementation" #LightYellow
end box

box "Testing" #LightOrange
end box

box "Deployment" #LightPurple
end box

box "Maintenance" #LightPink
end box

Requirements --> Design : "Approved Requirements"
Design --> Implementation : "Detailed Design"
Implementation --> Testing : "Working Code"
Testing --> Deployment : "Tested Product"
Deployment --> Maintenance : "Deployed Product"

@enduml
