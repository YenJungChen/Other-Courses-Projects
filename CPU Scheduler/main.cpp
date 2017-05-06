/**
 * A simple non-preemptive CPU Scheduler simulator
 * @author YJC
 * @since date this file was last modified
 */

#include <iostream>
#include <string>
#include <cstdlib>
#include "Heap.cpp"
#include "PCB.h"
#include <math.h>
#include <time.h>
using namespace std;

Heap<int> heap;

void Print(PCB *PCB, int NUM) {
    for (int i = 0; i < NUM; i++) {
        if (PCB[i].getPriority() == heap.peek())
            cout << PCB[i].getPid() << "," << PCB[i].getPriority() << "," << PCB[i].getLength() << endl;
    }
    heap.remove();
}

int RunningPCB(PCB *PCB, int NUM) {
    int Pid = 0;
    for (int i = 0; i < NUM; i++)
        if (PCB[i].getPriority() == heap.peek() && PCB[i].getStart() > 0) {
            Pid = PCB[i].getPid();
            break;
        }
    return Pid;
}

double RanQ() {
    return rand() % 100 / 100.0;
}

int main(int argc, char** argv) {
    cout << "Please enter the possibility(P) and cycle(S): ";
    double P = 0.5, alltime = 0;
    int NUM = 100, addingPid = 0, lenght = 0, waitingPid = 0, runningPid = -1;
    cin >> P;
    cin >> NUM;
    srand(time(NULL));
    PCB *pcb = new PCB[NUM];
    for (int i = 0; i < NUM; i++) {
        PCB tmp(i + 1, rand() % 19 - 20, 0, 0, rand() % 10 + 1);
        pcb[i] = tmp;
        pcb[i].setWait(0);
        pcb[i].setStart(-1);
    }
    for (int i = 0; i < NUM; i++) {
        cout << "*** Cycle #: " << i + 1 << endl;
        if (heap.size() > 0 && lenght != 0) {
            double time = clock() - pcb[runningPid - 1].getWait();
            time = time / CLOCKS_PER_SEC;
            pcb[runningPid-1].setWait(time);
            alltime += time;
            cout << "Process #" << runningPid << " is executing.\n";
            lenght--;
        }
        if (P >= RanQ()) {
            cout << "Adding job with pid #" << pcb[addingPid].getPid() << " and priority " << pcb[addingPid].getPriority() << " and length " << pcb[addingPid].getLength() << ".\n";
            heap.insert(pcb[addingPid].getPriority());
            if (lenght == 0 && runningPid != -1) {
                cout << "Process #" << runningPid << " has just terminated.\n";
                pcb[runningPid-1].setStart(-1);
                heap.remove();
                runningPid = -1;
                waitingPid--;
            }
            pcb[addingPid].setStart(i + 1);
            if (runningPid == -1){
                runningPid = RunningPCB(pcb, NUM);
                lenght = pcb[runningPid-1].getLength();
            }
            pcb[addingPid].setWait(clock());
            addingPid++;
            waitingPid++;
        }
        else
            cout << "No new job this cycle.\n";
    }
    cout << "The average turnaround is " << (double)clock() / CLOCKS_PER_SEC / NUM << " per cycle." << endl;
    cout << "The average wait time is " << alltime / addingPid << "." << endl;
    system("PAUSE");
    return 0;
}
