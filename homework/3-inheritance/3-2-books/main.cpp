#include <chrono>
#include <format>
#include <iostream>
#include <string.h>
#include <vector>

using std::string;

class PrintedEdition {
protected:
    string title;
    string authors;
    int year;

public:
    PrintedEdition(const string& title, const string& author, int year) : title(title), authors(author), year(year) {}

    virtual void display() {
        std::cout << std::format("Name: {}", title) << '\n'
        << std::format("Author: {}", authors) << '\n'
        << std::format("Year: {}", year) << std::endl;
    }

    string getName() {
        return title;
    };
};

class Book : public PrintedEdition {
protected:
    int pages;

public:
    Book(const string& title, const string& author, int year, int pages) : PrintedEdition(title, author, year), pages(pages) {}

    void display() override {
        PrintedEdition::display();
        std::cout << std::format("Pages: {}", pages) << std::endl;
    }
};

class TextBook : public Book {
private:
    string subject;

public:
    TextBook(const string& title, const string& author, int year, int page, const string& subject) : Book(title, author, year, page), subject(subject) {}

    void display() override {
        Book::display();
        std::cout << std::format("Subject: {}", subject) << std::endl;
    }
};

class Magazine : public PrintedEdition {
    string period;

public:
    Magazine(const string& title, const string& author, int year, string  period) : PrintedEdition(title, author, year), period(std::move(period)) {}

    void display() override {
        PrintedEdition::display();
        std::cout << std::format("Edition: {}", period) << std::endl;
    }

};

void printMenu();
std::vector<PrintedEdition*> editions;

int main() {
    //! just temporary buffer variables
    string a, b, c, d;
    int n, m;

    int command = 1;
    while (command != 0) {
        printMenu();
        std::cout << "enter command" << std::endl;
        std::cin >> command;

        switch (command) {
            case 1:
                std::cout << "Enter data like(str title, str author, int year)" << '\n';
            std::cin >> a >> b >> n;
            editions.push_back(new PrintedEdition(a, b, n));
                break;

            case 2:
                std::cout << "Enter data like(str title, str author, int year, int pages)" << '\n';
            std::cin >> a >> b >> n >> m;
            editions.push_back(new Book(a, b, n, m));
            break;

            case 3:
                std::cout << "Enter data like(str title, str author, int year, int pages, str subject)" << '\n';
            std::cin >> a >> b >> n >> m >> c;
            editions.push_back(new TextBook(a, b, n, m, c));
            break;

            case 4:
                std::cout << "Enter data like(str title, str author, int year, str period)" << '\n';
            std::cin >> a >> b >> n >> c;
            editions.push_back(new Magazine(a, b, n, c));
            break;

            case 5:
                for (auto& amogus: editions) {
                    amogus->display();
                    std::cout << std::endl;
                }
                break;

            case 6:
                std::cout << "enter name" << '\n';
            std::cin >> a;
            for (auto& amogus : editions) {
                if (strcmp(a.c_str(), amogus->getName().c_str()) == 0) {
                    amogus->display();
                    std::cout << std::endl;
                }
            }
            break;

            case 0:
                return 0;
            default:
                break;
        }
    }

    std::cout << "Hello, World!" << std::endl;
}

void printMenu() {
    std::cout << '\n'
    << "1. Add new PrintedEdition\n"
    << "2. Add new Book\n"
    << "3. Add new TextBook\n"
    << "4. Add new Magazine\n"
    << "5. Display all data\n"
    << "6. Searching by name\n"
    << "0. Exit" << std::endl;
}
