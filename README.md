# Stress Level Prediction Using Machine Learning

This project predicts stress levels in students using survey-style features such as 
financial issues, family issues, study hours, health issues, and academic pressure.

A synthetic dataset is generated to simulate survey responses, and a KNN classifier 
is trained to classify individuals as **Stressed** or **Stress-Free**.

## Pipeline

- Generate dataset (`dataset.csv`)
- Preprocess and encode features
- Train-test split
- Standardization
- Train KNN model
- Evaluate using classification report and confusion matrix

## Tech Stack

- Python
- Pandas, NumPy
- Scikit-Learn
- Matplotlib, Seaborn

## Files

- `stress_prediction.ipynb` – full ML workflow
- `dataset.csv` – synthetic dataset
- `report.pdf` – original academic paper (optional)

