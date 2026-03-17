using UnityEngine;
using System.Collections.Generic;
public class Gravitational : MonoBehaviour
{
    public static List<Gravitational> otherGameObject;
    private Rigidbody rb;
    const float G = 0.006674f; //6.674
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (otherGameObject == null) { otherGameObject = new List<Gravitational>(); } // ���ҧ��ª���������� obj ����
        otherGameObject.Add(this); // ���� Class Gravitational � obj ��������ª���
    }
    void FixedUpdate()
    {
        foreach (Gravitational obj in otherGameObject)
        { if (obj != this) { AttractionForce(obj); } } // ��ͧ�ѹ���������ç�֧�ٴ����ͧ
    }
    void AttractionForce(Gravitational other)
    {
        Rigidbody otherRb = other.rb;
        Vector3 dir = rb.position - otherRb.position; // �ҷ�ȷҧ����ѵ�ب�ⴹ�֧价ҧ�˹
        float dist = dir.magnitude; // ��������ҧ �����ҧ�ѵ��
        if (dist == 0f) { return; } // ��ͧ�ѹ�ѵ������͹�ҵ��˹����ǡѹ
        // �ٵäӹǳ�ç�֧�ٴ�����ç�����ǧ�����ҧ�ѵ�� F = G * ((m1 * M2) / r^2)
        float forceMagnitude = G * ((rb.mass * otherRb.mass) / Mathf.Pow(dist, 2));
        Vector3 gravitationalForce = forceMagnitude * dir.normalized; // ���ç��з�ȷҧ���������
        otherRb.AddForce(gravitationalForce); // �����ç��з�ȷҧ���������ѵ��
    }
}