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
    double getX() const {return x;}
    double getY() const {return y;}

    void display() const {
        std::cout
        << '(' << x << ", " << y << ')' << std::endl;
    }

    double getDistance() const {
        double xDiff = abs(x), yDiff = abs(y);
        return std::sqrt(xDiff*xDiff + yDiff*yDiff);
    }

    void moveCoords(const double x_, const double y_) {
        x += x_;
        y += y_;
    }

    Point operator++() const {
        return Point(x+1, y+1);
    }

    bool operator==(Point& p) const {
        return (x == p.x && y == p.y);
    }

    Point operator*(const double m) const {
        return Point {x * m, y * m};
    }

    Point operator+(const double a) const {
        return Point {x+a, y+a};
    }

    Point operator+(Point& p) const {
        return Point {x + p.x, y + p.y};
    }
};

std::ostream& operator<<(std::ostream& os, const Point& point) {
    os << "(" <<  point.getX() << ", " << point.getY() << ")";
    return os;
}

void operator>>(std::istream& is, Point& point) {
    double x, y;
    is >> x >> y;
    point.setX(x);
    point.setY(y);
}

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
    p2.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Multiplying point by M:" << '\n';
    std::cout << "Enter the multyplier" << '\n';
    std::cin >> x;
    p2 = p2 * x;
    p2.display();

    std::cout << "-------------------------" << '\n';
    std::cout << "# Overloading operators:" << '\n';
    Point a(1, 4), b(5, -7);
    a.display();
    b.display();
    Point c = a + b;
    std::cout << "a + b equals " << '\n';
    c.display();

    std::cout << "point++" << '\n';
    c = ++c;
    c.display();

    std::cout << "point + number" << '\n';
    std::cout << "Enter number" << '\n';
    std::cin >> x;
    std::cout << "Point(" << c.getX() << ", " << c.getY() << ") + " << x << " equals" << '\n';
    c = c + x;
    c.display();

    a = Point(1, 3);
    b = Point(1, 3);
    std::cout << "if (1, 3) equals (1, 3)" << '\n';
    bool result = a == b;
    std::cout << result << '\n';
    std::cout << "if (1, 3) equals (1, 5)" << '\n';
    b.setY(5);
    result = a == b;
    std::cout << result << '\n';

    std::cout << "-------------------------" << '\n';
    std::cout << "# To string display" << '\n';
    Point newPoint;
    std::cout << "Enter point (x, y)" << '\n';
    std::cin >> newPoint;
    std::cout << "The new point is: " << newPoint << std::endl;

    std::cout << "-------------------------" << '\n';
    std::cout << "# Calling destructors" << '\n';
}
