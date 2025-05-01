``` mermaid


classDiagram
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee
    IMammal <.. Dog
    IMammal <.. Cat
    IMammal <.. Bat
    ICanFly <.. Bat
    ICanFly <.. Bee

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

    <<interface>> IMammal
    IMammal : +NumberOfNipples

    <<interface>> ICanFly 
    ICanFly: +NumberOfWings
    

```