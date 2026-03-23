# Stress Level Prediction Using Machine Learning

This project predicts stress levels in students using survey‑style features such as 
financial issues, family background, study hours, health issues, and academic pressure.  
It includes both:

1. A **modern machine learning implementation** (Python + Scikit‑Learn)  
2. The **original academic ASP.NET application** (three‑tier architecture)

This repository represents the complete evolution of the project—from the original 
software engineering implementation to a clean, reproducible ML workflow.

---

##  Project Overview

The goal of this project is to classify individuals as:

- **Stressed**
- **Stress‑Free**

using a set of behavioral, academic, and personal attributes.  
A synthetic dataset is generated to simulate real survey responses, and a KNN classifier 
is trained to perform the prediction.

---

##  Machine Learning Workflow

The ML pipeline includes:

1. **Synthetic dataset generation**  
2. **Data preprocessing**
   - Encoding categorical variables  
   - Standardization  
3. **Train‑test split**
4. **Model training (KNN Classifier)**
5. **Model evaluation**
   - Classification report  
   - Confusion matrix  

The notebook `stress_prediction.ipynb` contains the full implementation.

---

##  Results

The model achieved:

- **Accuracy:** 99%  
- **Precision (Stressed):** 0.99  
- **Recall (Stressed):** 1.00  
- **F1‑Score (Stressed):** 0.99  

The confusion matrix and classification report are included in the notebook.

## Tech Stack

### **Machine Learning**
- Python  
- Pandas  
- NumPy  
- Scikit‑Learn  
- Matplotlib  
- Seaborn  

### **Original Academic Project**
- ASP.NET  
- C#  
- SQL Server  
- ADO.NET  
- Three‑tier architecture  

---

##  Original Academic Work

This repository includes the original ASP.NET implementation submitted as part of my 
Bachelor’s project, along with the conference and academic reports.  
The ML notebook represents a modern extension of the original idea.

---

##  How to Run the ML Notebook

1. Install dependencies:
pip install pandas numpy scikit-learn matplotlib seaborn
2. Open the notebook:
jupyter notebook stress_prediction.ipynb
3. Run all cells.

---

##  Future Improvements

- Hyperparameter tuning  
- Additional ML models (Random Forest, SVM, XGBoost)  
- Real survey dataset integration  
- API deployment using FastAPI or Flask  

---

##  Author

**Sreeja Kotha**  
Hybrid Data Engineer | Analytics Engineer | Backend Developer  
Munich, Germany  
