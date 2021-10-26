var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// declare class
// -------------------------------------------
var student = /** @class */ (function () {
    function student(id, name) {
        if (id === void 0) { id = 0; }
        if (name === void 0) { name = 'Roy'; }
        this.id = 0;
        this.firstName = "roy";
        this.id = id;
        this.firstName = name;
        console.log("Hello " + this.id + " - " + this.firstName);
    }
    return student;
}());
var anyStudents = [
    new student(1, 'Meliaz')
];
// -------------------------------------------
// declare var
// -------------------------------------------
var message = "Greetings, FSD OCBC 1";
var anyMessage = 123456;
var anyArray = [123456, ''];
console.log(message);
// -------------------------------------------
// declare fucntion
// -------------------------------------------
function greetParticipant(name, age) {
    console.log("Hello " + name + "! Your age is " + age + ".");
}
greetParticipant('Roy');
// -------------------------------------------
// declare array
// -------------------------------------------
var students2 = [
    ['Gusti', true, 261, ['hehe']],
    ['Ricky', true],
    'string'
];
var students1 = [
    ['Gusti', true, 261, ['hehe']],
    ['Ricky', true],
    'string'
];
// -------------------------------------------
// declare object
// -------------------------------------------
// object literal
// cara 1: declare type langsung
var student3 = {
    name: 'Budi',
    age: 71,
    score: 100
};
var anotherStudent = {
    name: 'Rara',
    age: 20,
    score: 100
};
var employees = [
    {
        name: "Bayu",
        age: 21,
        score: 100
    },
    anotherStudent,
    student3
];
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
var Person = /** @class */ (function () {
    // name: String;
    // private age:Number;
    function Person(name, age) {
        this.name = name;
        this.age = age;
        this.name = name;
        this.age = age;
    }
    Object.defineProperty(Person.prototype, "personAge", {
        get: function () {
            return this.age;
        },
        enumerable: false,
        configurable: true
    });
    return Person;
}());
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student(name, age, score, firstMentor) {
        var _this = 
        // this.name = name;
        // this.age = age;
        _super.call(this, name, age) || this;
        _this.mentors = [];
        _this.score = score;
        _this.mentors.push(firstMentor);
        return _this;
    }
    Student.prototype.changeScore = function (newscore) {
        this.score = newscore;
    };
    Student.prototype.addMentor = function (mentorname) {
        this.mentors.push(mentorname);
    };
    Object.defineProperty(Student.prototype, "studentName", {
        get: function () {
            return this.name;
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}(Person));
var riyan = new Student('Riyan', 22, 100, 'Arif');
console.log(riyan);
riyan.changeScore(105);
riyan.addMentor('Eas');
console.log(riyan);
console.log(riyan.studentName);
console.log(riyan.personAge);
// -------------------------------------------
