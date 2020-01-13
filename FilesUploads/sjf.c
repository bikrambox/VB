#include<stdio.h>

void tat(int b[],int w[],int n);

void avg_wt(int w_t[],int n);

void swap(int *xp,int *yp,int n);

void main()
{
	int bt[20], wt[20],n,i,j,temp;
	printf("Enter the number of processes:\n");
	scanf("%d",&n);
	printf("Enter the burst time:\n");
	for(i=0;i<n;i++)
	{
		scanf("%d",&bt[i]);
	}
	printf("Sorted burst time:\n");
	for(int l=0;l<n-1;l++)
	{
		for(int k=0;k<n-l-1;k++)
		{
			if(bt[k]>bt[k+1])
			{
				swap(&bt[k],&bt[k+1],n);
			}
		}
	}
	for(int m=0;m<n;m++)
	{
		printf("\t%d\n",bt[m]);
	}
	for(j=0;j<n;j++)
	{
		wt[j]=bt[j-1]+wt[j-1];
	}
	tat(bt,wt,n);
	avg_wt(wt,n);

}

void swap(int *xp,int *yp,int n)
{
	int temp=*xp;
	*xp=*yp;
	*yp=temp;
}

void tat(int b[],int w[],int n)
{
	int turn[20];
	double avg=0;
	printf("\nTAT:\n");
	for(int i=0;i<n;i++)
	{	
		turn[i]=0;
		turn[i]=b[i]+w[i];
		printf("\t%d\n",turn[i]);
	}
	printf("Average TAT:\n");
	for(int j=0;j<n;j++)
	{
		avg+=turn[j]/n;
	}
	printf("%.2f\n",avg);
}

void avg_wt(int w_t[],int n)
{
	double avg=0;
	printf("\nWT:\n");
	for(int i=0;i<n;i++)
	{	
		printf("\t%d\n",w_t[i]);
		avg+=w_t[i]/n;
	}
	printf("Average Waiting time:\n%.2f\n",avg);
}
