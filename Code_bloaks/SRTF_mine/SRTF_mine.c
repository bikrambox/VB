#include <stdio.h>

int main()
{   
    int n,at[20],wt[20],tat[20],bt[20],rt[20],endTime,i;
    int remain=0,time,av_wt=0,av_tat=0,a_small_number;

    printf("..::SHORTEST REMAINING TIME FIRST::..\n\n");
    printf("\tEnter the number of Processes::");
    scanf("%d",&n);

    for(i=0;i<n;i++)
    {
        printf("\t..::Enter the arrival time for process P%d:",i+1);
        scanf("%d",&at[i]);

        printf("..::Enter the Burst time of the process P%d:",i+1);
        scanf("%d",&bt[i]);
        rt[i]=bt[i];

    }
    

    printf("\nProcess ID\t  Arrival Time\t  Burst Time");
    rt[9]=9999;
    /*for(i=0;i<n;i++)
    {      
      printf("\n[%d]\t\t  %d\t\t  %d\t\t  ", i+1,at[i],bt[i]);//i+1 for the Process ID
   }
   */
for(time=0;remain!=n;time++)
    {
        a_small_number=9;
        for(i=0;i<n;i++)
        {
            if(at[i]<=time && rt[i]<rt[a_small_number] && rt[i]>0)
            {
                a_small_number=i;
            }
        }

        rt[a_small_number]--;

        if(rt[a_small_number]==0)
        {
            remain++;
            endTime=time+1;
            
            printf("\nP[%d]\t|\t%d\t|\t%d",a_small_number+1,endTime-at[a_small_number],endTime-bt[a_small_number]-at[a_small_number]);
            av_wt+=endTime-bt[a_small_number]-at[a_small_number];
            av_tat+=endTime-at[a_small_number];
        }
    }
    printf("\n\nAverage waiting time = %f\n",av_wt*1.0/n);
    printf("Average Turnaround time = %f",av_tat*1.0/5);
    return 0;
}

    
