module;
#include "iostream"
#include "vector"
#include "string"
#include "format"
import student;

export module subject;
export class subject
{
    std::string name;
    std::vector<student*> students;

public:
    subject()
    {
        name = "";
    }
    
    explicit subject(std::string name) : name(std::move(name))
    {
        std::cout << std::format("new subject: {}\n", name);
    }

    subject(std::string name, const subject& original) :
    name(std::move(name)),
    students(original.students)
    {
        std::cout << "Copied students from " << original.name << " to " << this->name << '\n';
    }

    std::string& get_name()
    {
        return name;
    }
    
    std::vector<student*>& get_students()
    {
        return students;
    }

    std::string format()
    {
        return std::format("Subject({}, {} students)\n", name, students.size());
    }

    void display()
    {
        std::cout << format();
    }

    void add_student(student* student)
    {
        students.push_back(student);
    }

    student& find_by_name(const std::string& first_name, const std::string& last_name)
    {
        for (const auto stud : students)
        {
            if (stud->get_first_name() == first_name && stud->get_last_name() == last_name)
            {
                return *stud;
            }
        }
        throw std::runtime_error(std::format("No such student {} {}", first_name, last_name));
    }
};
