// ReSharper disable CppClangTidyCppcoreguidelinesSpecialMemberFunctions
module;
#include "iostream"
#include "format"
#include "vector"
#include "string"

class subject;

export module student;

export class student
{
    std::string first_name;
    std::string last_name;
    std::string email;

    std::vector<subject*>* subjects;

public:
    student()
    {
        subjects = nullptr;
        first_name = last_name = email = "";
        std::cout << "created empty student at: " << this << '\n';
    }
    
    student(std::string first_name, std::string last_name, std::string email) :
    first_name(std::move(first_name)),
    last_name(std::move(last_name)),
    email(std::move(email))
    {
        std::cout << "new student created at: " << this << '\n';
    }

    student(const student& original) :
    first_name(original.first_name),
    last_name(original.last_name),
    email(original.email)
    {
        std::cout << "student " << this << " copied from " << &original << '\n';
    }

    std::string& get_first_name()
    {
        return first_name;
    }

    std::string& get_last_name()
    {
        return last_name;
    }

    std::string& get_email()
    {
        return email;
    }

    std::vector<subject*>* get_subjects()
    {
        return subjects;
    }

    std::string format()
    {
        return std::format("Student({}, {}, {})\n", first_name, last_name, email);
    }

    void display()
    {
        std::cout << format();
    }

    void add_subject(subject* subj)
    {
        subjects->push_back(subj);
    }
};    

class subject
{
    std::string name;
    std::vector<student*>* students;

public:
    subject()
    {
        name = "";
        students = nullptr;
    }
    explicit subject(std::string name) : name(std::move(name))
    {
        std::cout << std::format("new subject: {}\n", name);
    }

    subject(std::string name, const subject& original) :
    name(std::move(name))
    {
        std::cout << "Copied students from " << original.name << " to " << this->name << '\n';
        students = original.students;
    }

    std::string& get_name()
    {
        return name;
    }
    
    std::vector<student*>* get_students()
    {
        return students;
    }

    std::string format()
    {
        return std::format("Subject({}, {} students)\n", name, students->size());
    }

    void display()
    {
        std::cout << format();
    }
};
