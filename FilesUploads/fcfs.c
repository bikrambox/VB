#include<stdio.h>

int turn_around_t(int w[20],int b[20],int c);
int avg_wt(int a[20],int b);

int main()
{
	int i,j,k,n,bt[20],wt[20];
	printf("Enter number of processes:\n");
	scanf("%d",&n);
	printf("Enter the burst time:\n");
	for(i=0;i<n;i++)
	{
		scanf("%d",&bt[i]);
	}
	for(k=0;k<n;k++)
	{
		wt[k]=bt[k-1]+wt[k-1];
	}
	turn_around_t(wt,bt,n);
	avg_wt(wt,n);
	return 0;
}

int turn_around_t(int w[20],int b[20],int c)
{
	int tat[20],x;
	float avg=0;
	
	printf("TAT:\n");
	for(x=0;x<c;x++)
	{
		tat[x]=w[x]+b[x];
	}
	for(x=0;x<c;x++)
	{
		printf("%d\t",tat[x]);
		printf("\n");
	}
	
	printf("Average TAT:\n");
	for(x=0;x<c;x++)
	{
		avg+=tat[x]/c;
	}
	printf("%f\n",avg);
	return 0;
}

int avg_wt(int a[],int b)
{
	float avg_w=0;
	int y;
	printf("Waiting Time:\n");
	for(y=0;y<b;y++)
	{
		printf("%d\t",a[y]);
		printf("\n");
		avg_w+=a[y]/b;
	}
	printf("Average Waiting Time:\n");
	printf("%f\n",avg_w);
	return 0;
}

