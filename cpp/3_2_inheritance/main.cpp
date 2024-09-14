#include <iostream>
#include <string>
#include <memory>

class PrintPublication {
protected:
    std::string title;
    int year;

public:
    PrintPublication() : title("Title"), year(0) {}
    PrintPublication(const std::string& title, int year)
    : title(title), year(year) {}

    virtual ~PrintPublication() = default;

    virtual void printDetails() const {
        std::cout << "Title: " << title << ", Year: " << year << std::endl;
    }
};

class Book : public PrintPublication {
    std::string author;

public:
    Book(const std::string& title, int year, const std::string& author)
    : PrintPublication(title, year), author(author) {}

    void printDetails() const override {
        PrintPublication::printDetails();
        std::cout << "Author: " << author << std::endl;
    }
};

class Textbook : public Book {
    std::string subject;

public:
    Textbook(const std::string& title, int year, const std::string& author, const std::string& subject)
    : Book(title, year, author), subject(subject) {}

    void printDetails() const override {
        Book::printDetails();
        std::cout << "Subject: " << subject << std::endl;
    }
};

class Magazine : public PrintPublication {
    int issueNumber;

public:
    Magazine(const std::string& title, int year, int issueNumber)
    : PrintPublication(title, year), issueNumber(issueNumber) {}

    void printDetails() const override {
        PrintPublication::printDetails();
        std::cout << "Issue Number: " << issueNumber << std::endl;
    }
};

int main() {
    std::unique_ptr<PrintPublication> publications[4] {
        std::make_unique<Book>("Harry Harrington", 1991, "John Wednesday"),
        std::make_unique<Textbook>("Introduction to Algorithms", 2009, "Thomas H Cormen", "Algorithms"),
        std::make_unique<Magazine>("National Geographic", 2024, 9),
        std::make_unique<PrintPublication>("Generic Publication", 2024)
    };

    for (const auto& publication : publications) {
        publication->printDetails();
        std::cout << std::endl;
    }

    return 0;
}
