``` mermaid


classDiagram
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee
    IMammal <|-- Dog
    IMammal <|-- Cat
    IMammal <|-- Bat
    ICanFly <|-- Bat
    ICanFly <|-- Bee

    class Animal {
        +Sound() string
    }

    class Dog {
        +Sound() string
    }

    class Cat {
        +Sound() string
    }

    class Bat {
        +Sound() string
    }

    class Bee {
        +Sound() string
    }

    class IMammal{
        +NumberOfNipples: int <<readOnly>>
    }
    
    class ICanFly {
        +NumberOfWings: int <<readOnly>>
    }
```