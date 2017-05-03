#include <iostream>
#include <cstdlib>  
#include <stdexcept>
#include <iomanip>
#include <fstream> 
#include <string.h>
#include "AVLTree.cpp"
#include "BSTree.cpp"
#include "WordStat.h"
#define MAX 1000
using namespace std;

string toUpper(string w)
{
	int i;
	for (i = 0; i <= w.length(); i++)
		w[i] = toupper(w[i]);
	return w;
}

WordStat Input[MAX];
int tablecount = 1;
void PrintTraversal(string file) {//
	cout << "Table " << tablecount << ":";
	if (tablecount % 2 == 1)
		cout << "Binary Search Tree [" << file << "]" << endl;
	else
		cout << "AVL Tree [" << file << "]" << endl;
	if (tablecount < 3)
		cout << "In-order Traversal" << endl;
	else
		cout << "Level-order Traversal" << endl;
	cout << "===================================" << endl;
	cout << "Word"<<setw(5)<<"Frequency" << endl;
	cout << "-----------------------------------" << endl;
	tablecount++;
}
void PrintLine() {
	cout << "-----------------------------------" << endl << endl;
}
void PrintWord(const string &s) {
	cout << s << setw(5);
	for (int i = 0; i < MAX; i++)
		if (s == Input[i].getWord()) {
			cout << Input[i].getCount() << endl;
			break;
		}
}
void PrintT5(string file) {
	cout << "Table 5:Number of Nodes vs Height\nUsing Data in [" << file << "]" << endl;
	cout << "===================================" << endl;
	cout << "Tree"<<setw(5)<<"# Nodes"<<setw(5) <<" Height" << endl;
	cout << "-----------------------------------" << endl;
}
void PrintT6(string file) {
	cout << "Table 6:Total Number of Nodes Accessed\nSearching for all the Words in [" << file << "]" << endl;
	cout << "===================================" << endl;
	cout << "Tree"<<setw(5)<<"# Nodes" << endl;
	cout << "-----------------------------------" << endl;
}

int main(int argc, char** argv)
{
    
    string file = "/Users/baby/Desktop/C-workspace/BSTvAVL/BSTvAVL/fox.txt";
//file = argv[1];
	AVLTree<string> AVL;
	BSTree<string> BST;
	char line[100];
	ifstream fin;
	
	int WordCount = 0;
	fin.open(file);
	if (!fin)
		cout << "Fail to open the file";
	else {
		while (fin.getline(line, sizeof(line), '\n')) {
			char* token;
			token = strtok(line, " ");
			while (token != NULL) {
				WordStat tmp(toUpper(token), 0);
				if (!AVL.inTree(tmp.getWord())) {
					Input[WordCount] = tmp;
					Input[WordCount].updateCount(1);
					AVL.insert(Input[WordCount].getWord());
					BST.insert(Input[WordCount].getWord());
					cout << Input[WordCount].getWord() << " ";
					WordCount++;
				}
				else {
					for (int i = 0; i < MAX; i++)
						if (tmp == Input[i]) {
							Input[i].updateCount(1);
							cout << "'" << Input[i].getWord() << "' ";
							break;
						}
				}
				token = strtok(NULL, " ");
			}
			cout << endl;
		}
		fin.close();
	
        PrintTraversal(file);
        BST.traverse(PrintWord);
        PrintLine();
        PrintTraversal(file);
        AVL.traverse(PrintWord);
        PrintLine();
        PrintTraversal(file);
        BST.levelTraverse(PrintWord);
        PrintLine();
        PrintTraversal(file);
        AVL.levelTraverse(PrintWord);
        PrintLine();
	
        PrintT5(file);
        cout << "BST"<<setw(5) << BST.size() << setw(5) << BST.height() + 1 << endl;
        cout << "AVL"<<setw(5) << AVL.size() << setw(5)  << AVL.height() + 1 << endl;
        PrintLine();
        PrintT6(file);
        int BSTcount = 0, AVLcount = 0, num = 0;
        while (Input[num].getCount() != 0) {
            BSTcount += BST.depth(Input[num].getWord()) + 1;
            AVLcount += AVL.depth(Input[num].getWord()) + 1;
            num++;
        }
        cout << "BST"<<setw(5) << BSTcount << endl;
        cout << "AVL"<<setw(5) << AVLcount << endl;
        PrintLine();
    }
    
	//system("pause");
	return 0;
}

