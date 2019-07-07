# include <iostream>
# include <vector>

using namespace std;

class Animal
{
	private:
        int height;
	int weight;
	string name;

	public:
        int getHeight() { return height; }
	int getWeight() { return weight; }
	string getName() { return name; }
	vector<Animal>* friends;
	void print_friends()
	{
		for (Animal a : *friends)
		{
			cout << a.getName() << endl;
		}
	};
	Animal(int height, int weight, string name) :

		height(height), weight(weight), name(name) { };

};

class Dog : public Animal {

    private:
        string sound = "woof";
public:
        void getSound() { cout << sound << endl; }
Dog(int h, int w, string n) : Animal(h, w, n) { };
};

void set_friends(Dog& d)
{
	Animal b(1, 2, "bb");
	vector<Animal> d_friends;
	d_friends.push_back(b);
	d.friends = &d_friends;
}
int main()
{
	Dog d(1, 2, "doggy");
	set_friends(d);
	d.print_friends();
	return 0;
}
c++ beginner object-oriented