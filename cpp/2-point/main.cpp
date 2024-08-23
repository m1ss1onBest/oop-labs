#include <iostream>
#include <valarray>

class Point {
    double x;
    double y;

public:
    Point() : x(0), y(0) {
        std::cout << "Called default constructor " << this << std::endl;
    }

    Point(const double x_, const double y_) : x(x_), y(y_) {
        std::cout << "Called constructor " << this << std::endl;
    }

    Point(const Point& point) : x(point.x), y(point.y) {
        std::cout << "Called copying constructor " << this << std::endl;
    }

    ~Point() {
        std::cout << "Called destructor " << this << std::endl;
    }

    void setX(const double x_) {x = x_;}
    void setY(const double y_) {y = y_;}
    double getX() {return x;}
    double getY() {return y;}

    void display() const {
        std::cout
        << '(' << x << ", " << y << ')' << std::endl;
    }

    double getDistance() {
        double xDiff = abs(x), yDiff = abs(y);
        return std::sqrt(xDiff*xDiff + yDiff*yDiff);
    }

    void moveCoords(const double x_, const double y_) {
        x += x_;
        y += y_;
    }

    void multiply(const double m) {
        x *= m;
        y *= m;
    }
};

int main() {
    double x, y;

    std::cout << "-------------------------" << '\n';
    std::cout << "# Default constructor:" << '\n';
    Point p1{};
    p1.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Destructor with:" << '\n';
    std::cout << "Enter point coords" << '\n';
    std::cin >> x >> y;
    Point p2 = Point(x, y);
    p2.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Distance from (0, 0) to point:" << '\n';
    double diff = p2.getDistance();
    std::cout << "Distance = " << diff << '\n';

    std::cout << "-------------------------" << '\n';
    std::cout << "# Move coords:" << '\n';
    std::cout << "Enter coords offset (x, y)" << '\n';
    std::cin >> x >> y;
    p2.moveCoords(x, y);
    p2.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Setting value" << '\n';
    std::cout << "Enter the new X of point" << '\n';
    std::cin >> x;
    p2.setX(x);
    std::cout << "The new X of point is: " << p2.getX() << '\n';
    std::cout << "Enter the new y of point" << '\n';
    std::cin >> y;
    p2.setY(y);
    std::cout << "The new Y of point is: " << p2.getY() << '\n';

    std::cout << "-------------------------" << '\n';
    std::cout << "# Multiplying point by M:" << '\n';
    std::cout << "Enter the multyplier" << '\n';
    std::cin >> x;
    p2.multiply(x);
    p2.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Calling destructors" << '\n';
}
