// declare class
// -------------------------------------------
class student {
    private id:number=0;
    public firstName:string = "roy";
    constructor(id:number=0, name:string='Roy') {
        this.id = id
        this.firstName = name
        console.log(`Hello ${this.id} - ${this.firstName}`)
    }
}

const anyStudents:student[]=[
    new student(1,'Meliaz')
]
// -------------------------------------------

// declare var
// -------------------------------------------
const message:string = "Greetings, FSD OCBC 1"
const anyMessage:string|number = 123456
const anyArray:(string|number)[] = [123456,'']
console.log(message)
// -------------------------------------------

// declare fucntion
// -------------------------------------------
function greetParticipant(name:string,age?:number) {
    console.log(`Hello ${name}! Your age is ${age}.`)
}
greetParticipant('Roy')
// -------------------------------------------

// declare array
// -------------------------------------------
let students2: ((string | boolean | number | string[])[]|string)[] = [
    ['Gusti',true,261, ['hehe']],
    ['Ricky',true],
    'string'
]

let students1: any[] = [
    ['Gusti',true,261, ['hehe']],
    ['Ricky',true],
    'string'
]
// -------------------------------------------

// declare object
// -------------------------------------------
// object literal
// cara 1: declare type langsung
let student3: {
    name:string
    age:number | string
    score:number
    address?:string
} = {
    name: 'Budi',
    age: 71,
    score: 100
}

// object instance
// cara 2: declare type lewat interface
interface StudentObject {
    name:string
    age:number | string
    score:number
}
let anotherStudent: StudentObject ={
    name: 'Rara',
    age: 20,
    score: 100
}

let employees: StudentObject[] = [
    {
    name: "Bayu",
    age: 21,
    score: 100
    },
    anotherStudent,
    student3
]

// class Person{}
// // inheritance dapet
// // interface juga dapet
// class Student1 extends Person implements StudentObject {
//     private id: number | undefined;
//     private mentors: string[] = [];
    
//     public name:string = 'Budi';
//     public age:number = 0;
//     public score:number = 0;

//     constructor(id:number, name:string) {
//         super();
//         this.id = id;
//         this.name = name;
//     }
// }


class Person {
    // name: String;
    // private age:Number;

    constructor(protected name:String, private age:number) {
        this.name = name;
        this.age = age;
    }

    get personAge():number {
        return this.age
    }
}

class Student extends Person {
    // public name:string;
    // public age:number;
    score:number;
    mentors: string[] = [];

    constructor(name:string, age:number, score:number, firstMentor:string) {
        // this.name = name;
        // this.age = age;
        super(name,age)
        this.score = score;
        this.mentors.push(firstMentor)
    }

    changeScore(newscore:number) {
        this.score = newscore
    }

    addMentor(mentorname:string) {
        this.mentors.push(mentorname)
    }

    get studentName() {
        return this.name
    }
}

const riyan = new Student('Riyan', 22, 100, 'Arif')
console.log(riyan)
riyan.changeScore(105)
riyan.addMentor('Eas')
console.log(riyan)
console.log(riyan.studentName)
console.log(riyan.personAge)
// -------------------------------------------


