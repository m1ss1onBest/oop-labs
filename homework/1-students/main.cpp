#include <cstdint>
#include <iostream>
#include <cstring>

class Student {
    char* name = nullptr;
    int age;
    int mark;

public:
    Student() : age(0), mark(0) {
        std::cout << "Called empty constructor on: " << this << std::endl;
    }


    Student(const char* name_, const int age_ = 0, const int mark_ = 0)
        : age(age_),
          mark(mark_)
    {
        name = new char[strlen(name_) + 1];
        strcpy(name, name_);
        std::cout << "Called constructor with params: " << this << std::endl;
    }

    Student(const Student& student)
        : age(student.age),
          mark(student.mark)
    {
        name = new char[strlen(student.name) + 1];
        strcpy(name, student.name);

        std::cout << "Called copying constructor on: " << this << std::endl;
    }

    void display() const {
        std::cout
        << "- Name: " << name << '\n'
        << "- Age: " << age << '\n'
        << "- Mark: " << mark << std::endl;
    }

    char* getName() const {return name;}
    int getAge() const {return age;}
    int getMark() const {return mark;}

    void setName(const char* name_) {
        delete[] name;
        name = new char[strlen(name_) + 1];
        strcpy(name, name_);
    }
    void setAge(const int age_) {age = age_;}
    void setMark(const int mark_) {mark = mark_;}

    ~Student() {
        delete[] name;
        std::cout << "Called destructor: " << this << std::endl;
    }
};

int main()
{
    std::string _name; // A crutch I couldn't fix?
    int age;
    int mark;

    std::cout << "-------------------------" << '\n';
    std::cout << "# Default constructor (no args): " << '\n';
    Student defaultStudent = Student();
    defaultStudent.setName("");
    defaultStudent.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Parametrized constructor: " << '\n';
    std::cout << "Enter `(name, age, mark)` of the student: " << '\n';
    std::cin >> _name >> age >> mark;
    const char *name = _name.c_str();
    Student student(name, age, mark);
    student.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Copying constructor: " << '\n';
    Student copyStudent(student);
    copyStudent.setName("Changed name");
    copyStudent.display(); // Constructor called explicitly

    std::cout << "-------------------------" << '\n';
    std::cout << "# Student pointer & Destructor: " << '\n';
    auto* studentPtr = &student;
    studentPtr->display();
    studentPtr->~Student();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Member function pointer: " << '\n';
    void (Student::*methodPointer)() const = &Student::display;
    (student.*methodPointer)();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Destructors: " << '\n';
}
