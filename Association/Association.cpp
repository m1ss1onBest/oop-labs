#include <iostream>

import student;
import subject;

int main(int argc, char* argv[])
{
    student s1("John", "Doe", "john.doe@example.com");
    student s2("Jane", "Smith", "jane.smith@example.com");
    student s3("Alice", "Johnson", "alice.johnson@example.com");

    subject math("Mathematics");
    math.add_student(&s1);
    math.add_student(&s2);
    math.add_student(&s3);

    math.display();

    try {
        student& found_student = math.find_by_name("Jane", "Smith");
        std::cout << "Found student: ";
        found_student.display();
    } catch (const std::runtime_error& e) {
        std::cerr << e.what() << '\n';
    }

    subject physics("Physics", math);
    physics.display();
    
    return 0;
}
