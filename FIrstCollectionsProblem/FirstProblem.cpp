#include <deque>
#include <filesystem>
#include <map>
#include <iostream>

int main(int argc, char* argv[])
{
    //create deque
    std::deque<int> myDeque {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

    //push in deque
    myDeque.push_back(999);
    myDeque.push_front(-999);

    //print
    for (auto elem : myDeque) {
        std::cout << elem << ", ";
    }
    std::cout << '\n' << std::flush;

    //removing an element
    auto it = std::ranges::find(myDeque, 4);
    if (it != myDeque.end())
    {
        myDeque.erase(it);
    }

    // print after remove
    for (auto elem : myDeque)
    {
        std::cout << elem << ", ";
    }
    std::cout << '\n' << std::flush;

    //len and max size
    std::cout << "size: " << myDeque.size() << '\n';
    std::cout << "max size: " << myDeque.max_size() << '\n';

    //shrinking the deque
    myDeque.resize(3);
    std::cout << "size: " << myDeque.size() << '\n';

    //iterators
    std::deque<int>::iterator iter;
    for(iter = myDeque.begin(); iter != myDeque.end(); iter++)
    {
        std::cout << *iter << ' ';
    }
    std::cout << '\n' << std::flush;

    return 0;
}
